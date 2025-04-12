using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasiID.Domains
{
    public static class CustomMessage
    {
        public const string GENERIC_ERROR = "An error occured.";
        public const string SIGNING_ERROR = "An error occured while signing.";
        public const string WRONG_PIN_ERROR = "Wrong PIN.";

        public const string START_READING_CARD = "Reading card..";

        public const string END_READING_CARD_SUCCESS = "Card was read successfully.";
        public const string END_READING_CARD_FAILURE = "An error occured while reading card.";

        public const string INVALID_EMAIL_FORMAT_ERROR = "Invalid email format.";
        public const string ACCOUNT_PIN_MISMATCH = "Account PIN mismatch.";
        public const string MISSING_FIELD = "All fields must be filled.";

        public const string START_ACCOUNT_CREATION = "Account is being created..";

        public const string END_ACCOUNT_CREATION_SUCCESS = "Account was created successfully.";
        public const string END_ACCOUNT_CREATION_FAILURE = "An error occured while creating account.";

        public const string EMPTY = "";

    }
}
