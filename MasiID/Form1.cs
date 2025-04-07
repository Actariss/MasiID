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

namespace MasiID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void get_Data_From_Card(object sender, EventArgs e)
        {
            using (Readers readers = new Readers(ReaderScope.User))
            {
                try
                {
                    EidCard eid = (EidCard)readers.ListCards().FirstOrDefault(c => c is EidCard);

                    if (eid == null)
                    {
                        Error_field.Text = "Aucune carte eID détectée.";
                        birthBox.Text = string.Empty;
                        nameBox.Text = string.Empty;
                        surnameBox.Text = string.Empty;
                        sexBox.Text = string.Empty;
                        cardNbrBox.Text = string.Empty;
                        return;
                    }

                    using (eid)
                    {
                        eid.Open();

                        X509Certificate2 auth = eid.AuthCert;
                        Egelke.Eid.Client.Model.Identity identity = eid.Identity;

                        Console.WriteLine(identity);

                        birthBox.Text = identity.DateOfBirth.ToShortDateString();
                        nameBox.Text = identity.FirstNames.Split(" ")[0];
                        surnameBox.Text = identity.Surname;
                        sexBox.Text = identity.Gender.ToString();
                        cardNbrBox.Text = identity.CardNr;
                        Error_field.Text = "";
                    }
                }
                catch (NoCardException)
                {
                    Error_field.Text = "No card detected in the reader";
                    birthBox.Text = string.Empty;
                    nameBox.Text = string.Empty;
                }
                catch (ReaderException)
                {
                    Error_field.Text = "The reader is not detected";
                    birthBox.Text = string.Empty;
                    nameBox.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    Error_field.Text = $"Erreur : {ex.Message}";
                    birthBox.Text = string.Empty;
                    nameBox.Text = string.Empty;
                }
            }
        }

public class UserData
    {
  
        public string Sexe { get; set; }
        public string BirthDate { get; set; }
        public string NumCard { get; set; }
        public string PinCode { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
}

public async Task SendDataToApiAsync(string sexe, string birth, string numcard, string pincode,string email, string name, string surname)
        {
            var client = new HttpClient();

            var data = new UserData
            {
                Sexe = sexe,
                BirthDate = birth,
                NumCard = numcard,
                PinCode = pincode,
                Email = email,
                Name = name,
                Surname = surname
            };

            var json = JsonSerializer.Serialize(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("http://192.168.91.138:5000/register", content);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data sended successfully");
                }
                else
                {
                    MessageBox.Show($"Error during sending : {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception : {ex.Message}");
            }
        }


        bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private async void Send_Click(object sender, EventArgs e)
        {
            var Sexe = sexBox.Text;
            var BirthDate = birthBox.Text;
            var NumCard = cardNbrBox.Text;
            var PinCode = pinBox.Text;
            var ConfPinCode = pinConfirmBox.Text;
            var Email = emailBox.Text;
            var Name = nameBox.Text;
            var Surname = surnameBox.Text;
            var EmailVerif = IsValidEmail(Email);
            bool error = false;
            Error_field.Text = "";
            if (!EmailVerif)
            {
                error = true;
                Error_field.Text += "Email Invalide\n";
            }
            if (PinCode != ConfPinCode || string.IsNullOrEmpty(PinCode))
            {
                error = true;
                Error_field.Text += "Pin missmatch or invalid\n";
            }
            if (string.IsNullOrEmpty(Sexe) || string.IsNullOrEmpty(BirthDate) || string.IsNullOrEmpty(NumCard) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Email))
            {
                error = true;
                Error_field.Text += "All fields should be filled\n";
            }
            if (!error)
            {
                await SendDataToApiAsync(Sexe, BirthDate, NumCard, PinCode, Email, Name, Surname);
            }
           
            


        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the input
            }
        }
    }
}
