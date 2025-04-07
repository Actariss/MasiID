using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MasiID.Domains
{
    public class User
    {
        public required string Sexe { get; set; }
        public required string BirthDate { get; set; }
        public required string NumCard { get; set; }
        public required string PinCode { get; set; }
        public required string Email { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string PinCodeConfirm { get; set; }

        public required string StreetAndNumber { get; set; }
        public required string Zip { get; set; }
        public required string Municipality { get; set; }


        // public required byte[] Picture { get; set; }


        public static bool IsValidEmail(string email) {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        internal string IsValidUser()
        {
            string error = "";
            if (!IsValidEmail(this.Email))
            {
                error += "Email Invalide\n";
            }

            if (PinCode != PinCodeConfirm || string.IsNullOrEmpty(PinCode))
            {
                error += "Pin missmatch or invalid\n";
            }

            if (string.IsNullOrEmpty(Sexe) || string.IsNullOrEmpty(BirthDate) || string.IsNullOrEmpty(NumCard) || string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Surname) || string.IsNullOrEmpty(Email))
            {
                error += "All fields should be filled\n";
            }

            return error;
        }
    }
}
