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

namespace MasiID
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void get_Data_From_Card(object sender, EventArgs e)
        {
            using (Readers readers = new(ReaderScope.User))
            {
                try
                {
                    EidCard eid = (EidCard)readers.ListCards().FirstOrDefault(c => c is EidCard);

                    if (eid == null)
                    {
                        ErrorLabel.Text = "Aucune carte eID détectée.";
                        birthBox.Text = string.Empty;
                        NameBox.Text = string.Empty;
                        SurnameBox.Text = string.Empty;
                        SexBox.Text = string.Empty;
                        CardNbrBox.Text = string.Empty;
                        return;
                    }

                    using (eid)
                    {
                        eid.Open();

                        X509Certificate2 auth = eid.AuthCert;
                        Egelke.Eid.Client.Model.Identity identity = eid.Identity;

                        birthBox.Text = identity.DateOfBirth.ToShortDateString();
                        NameBox.Text = identity.FirstNames.Split(" ")[0];
                        SurnameBox.Text = identity.Surname;
                        SexBox.Text = identity.Gender.ToString();
                        CardNbrBox.Text = identity.CardNr;
                        ErrorLabel.Text = "";
                    }
                }
                catch (NoCardException)
                {
                    ErrorLabel.Text = "No card detected in the reader";
                }
                catch (ReaderException)
                {
                    ErrorLabel.Text = "The reader is not detected";
                }
                catch (Exception ex)
                {
                    ErrorLabel.Text = $"Erreur : {ex.Message}";
                }
            }
        }

        private async void Send_Click(object sender, EventArgs e)
        {
            User user = new()
            {
                Sexe = SexBox.Text,
                BirthDate = birthBox.Text,
                NumCard = CardNbrBox.Text,
                PinCode = PinBox.Text,
                PinCodeConfirm = PinConfirmBox.Text,
                Email = EmailBox.Text,
                Name = NameBox.Text,
                Surname = SurnameBox.Text
            };

            string error = user.IsValidUser();
            if (!string.IsNullOrEmpty(error))
            {
                ErrorLabel.Text = error;
                return;
            }

            await Network.SendDataToApiAsync(user);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
