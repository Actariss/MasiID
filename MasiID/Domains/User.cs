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
    public class User(string sexe, string birthDate, string numCard, string pinCode, string pinCodeConfirm,
        string email, string name, string surname, string municipality, string zip, string streetAndNumber)
    {
        private string sexe = sexe;
        private string birthDate = birthDate;
        private string numCard = numCard;
        private string pinCode = pinCode;
        private string pinCodeConfirm = pinCodeConfirm;
        private string email = email;
        private string name = name;
        private string surname = surname;

        private string municipality = municipality;
        private string zip = zip;
        private string streetAndNumber = streetAndNumber;

        // Setters
        public void SetSexe(string sexe)
        {
            this.sexe = sexe;
        }

        public void SetBirthDate(string birthDate)
        {
            this.birthDate = birthDate;
        }

        public void SetNumCard(string numCard)
        {
            this.numCard = numCard;
        }

        public void SetPinCode(string pinCode)
        {
            this.pinCode = pinCode;
        }

        public void SetPinCodeConfirm(string pinCodeConfirm)
        {
            this.pinCodeConfirm = pinCodeConfirm;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSurname(string surname)
        {
            this.surname = surname;
        }

        public void SetMunicipality(string municipality)
        {
            this.municipality = municipality;
        }

        public void SetZip(string zip)
        {
            this.zip = zip;
        }

        public void SetStreetAndNumber(string streetAndNumber)
        {
            this.streetAndNumber = streetAndNumber;
        }

        // Getters
        public string GetSexe()
        {
            return this.sexe;
        }

        public string GetBirthDate()
        {
            return this.birthDate;
        }

        public string GetNumCard()
        {
            return this.numCard;
        }

        public string GetPinCode()
        {
            return this.pinCode;
        }

        public string GetPinCodeConfirm()
        {
            return this.pinCodeConfirm;
        }

        public string GetEmail()
        {
            return this.email;
        }

        public string GetName()
        {
            return this.name;
        }

        public string GetSurname()
        {
            return this.surname;
        }

        public string GetMunicipality()
        {
            return this.municipality;
        }

        public string GetZip()
        {
            return this.zip;
        }

        public string GetStreetAndNumber()
        {
            return this.streetAndNumber;
        }

        public Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>
            {
                { "sexe", this.GetSexe() },
                { "birthDate", this.GetBirthDate() },
                { "numCard", this.GetNumCard() },
                { "pinCode", this.GetPinCode() },
                { "pinCodeConfirm", this.GetPinCodeConfirm() },
                { "email", this.GetEmail() },
                { "name", this.GetName() },
                { "surname", this.GetSurname() },
                { "municipality", this.GetMunicipality() },
                { "zip", this.GetZip() },
                { "streetAndNumber", this.GetStreetAndNumber() }
            };
        }



        public static bool IsValidEmail(string email) {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public string IsValidUser()
        {
            string error = "";
            if (!IsValidEmail(this.email))
            {
                error += CustomMessage.INVALID_EMAIL_FORMAT_ERROR;
                error += "\n";
            }

            if (this.pinCode != this.pinCodeConfirm || string.IsNullOrEmpty(this.pinCode))
            {
                error += CustomMessage.ACCOUNT_PIN_MISMATCH;
                error += "\n";
            }

            if (string.IsNullOrEmpty(this.sexe) || string.IsNullOrEmpty(this.birthDate) || string.IsNullOrEmpty(this.numCard) || string.IsNullOrEmpty(this.name) || string.IsNullOrEmpty(this.surname) || string.IsNullOrEmpty(this.email))
            {
                error += CustomMessage.MISSING_FIELD;
                error += "\n";
            }

            return error;
        }
    }
}
