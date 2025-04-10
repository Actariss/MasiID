using Egelke.Eid.Client;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MasiID.Domains;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using MaterialSkin.Controls;
using MaterialSkin;
using Egelke.Eid.Client.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;
using MasiID.Forms;
using System.Security.Cryptography;
using PCSC.Iso7816;
using SmartCardService;

namespace MasiID
{
    public partial class Main : MaterialForm
    {

        private X509Certificate2 auth;
        private X509Certificate2 sign;
        private SmartCard smartCard;

        public Main()
        {
            InitializeComponent();

            MaterialSkin.MaterialSkinManager materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red700, Primary.Red800,
            Primary.Red500, Accent.Blue200, TextShade.WHITE);

            smartCard = new SmartCard();
         }

        private async void ReadDataFromCard(object sender, EventArgs e)
        {
            ErrorLabel.Text = "Lecture de la carte en cours...";

            await Task.Run(() =>
            {
                using (Readers readers = new(ReaderScope.User))
                {
                    try
                    {
                        EidCard eid = (EidCard)readers.ListCards().FirstOrDefault(c => c is EidCard);

                        if (eid == null)
                        {
                            this.Invoke((System.Windows.Forms.MethodInvoker)(() =>
                            {
                                ErrorLabel.Text = "Aucune carte eID détectée.";
                                BirthDateBox.Text = string.Empty;
                                NameBox.Text = string.Empty;
                                SurnameBox.Text = string.Empty;
                                SexBox.Text = string.Empty;
                                CardNbrBox.Text = string.Empty;
                                StreetAndNumberBox.Text = string.Empty;
                                MunicipalityBox.Text = string.Empty;
                                ZipBox.Text = string.Empty;
                                pictureBox.Image = null;

                            }));
                            return;
                        }

                        using (eid)
                        {
                            eid.Open();

                            auth = eid.AuthCert;
                            sign = eid.SignCert;

                            Identity identity = eid.Identity;
                            Address address = eid.Address;
                            byte[] picture = eid.Picture;


                            this.Invoke((System.Windows.Forms.MethodInvoker)(() =>
                            {
                                BirthDateBox.Text = identity.DateOfBirth.ToShortDateString();
                                NameBox.Text = identity.FirstNames.Split(" ")[0];
                                SurnameBox.Text = identity.Surname;
                                SexBox.Text = identity.Gender.ToString();
                                CardNbrBox.Text = identity.CardNr;
                                StreetAndNumberBox.Text = address.StreetAndNumber;
                                MunicipalityBox.Text = address.Municipality;
                                ZipBox.Text = address.Zip;
                                pictureBox.Image = PictureHelper.GetImage(picture);
                                ErrorLabel.Text = "";
                            }));
                        }
                    }
                    catch (NoCardException)
                    {
                        this.Invoke((System.Windows.Forms.MethodInvoker)(() =>
                        {
                            ErrorLabel.Text = "No card detected in the reader";
                        }));
                    }
                    catch (ReaderException)
                    {
                        this.Invoke((System.Windows.Forms.MethodInvoker)(() =>
                        {
                            ErrorLabel.Text = "The reader is not detected";
                        }));
                    }
                    catch (Exception ex)
                    {
                        this.Invoke((System.Windows.Forms.MethodInvoker)(() =>
                        {
                            ErrorLabel.Text = $"Erreur : {ex.Message}";
                        }));
                    }
                }
            });
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            using (var pinDialog = new PinDialog())
            {
                if (pinDialog.ShowDialog() != DialogResult.OK)
                    return;

                string pin = pinDialog.Pin;

                User user = new()
                {
                    Sexe = SexBox.Text,
                    BirthDate = BirthDateBox.Text,
                    NumCard = CardNbrBox.Text,
                    PinCode = PinBox.Text,
                    PinCodeConfirm = PinConfirmBox.Text,
                    Email = EmailBox.Text,
                    Name = NameBox.Text,
                    Surname = SurnameBox.Text,

                    StreetAndNumber = StreetAndNumberBox.Text,
                    Municipality = MunicipalityBox.Text,
                    Zip = ZipBox.Text
                };

                string error = user.IsValidUser();
                if (!string.IsNullOrEmpty(error))
                {
                    ErrorLabel.Text = error;
                    return;
                }

                try
                {
                    string userData = JsonSerializer.Serialize(user);
                    string hashedUserData = HashUtility.ComputeSha256Hash(userData);

                    smartCard.Connect();

                    bool status = smartCard.MseSet();
                    if (!status)
                    {
                        ErrorLabel.Text = $"Erreur lors de la signature.";
                        smartCard.LogOff();
                        return;
                    }


                    status = smartCard.VerifyPin(pin);
                    if (!status)
                    {
                        ErrorLabel.Text = $"Pin invalide.";
                        smartCard.LogOff();
                        return;
                    }

                    status = smartCard.SignData(hashedUserData);
                    if (!status)
                    {
                        ErrorLabel.Text = $"Erreur lors de la signature.";
                        smartCard.LogOff();
                        return;
                    }

                    byte[] signature = smartCard.GetResponse();
                    smartCard.LogOff();

                    // === Send to API ===
                    await Network.SendDataToApiAsync(userData, signature, sign);

                    ErrorLabel.Text = "";
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = $"Erreur lors de la signature.";
                }
            }

        }
        private void CheckDigits(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
