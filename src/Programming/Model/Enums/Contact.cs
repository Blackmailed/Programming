using DocuSign.eSign.Model;

namespace Programming.Model.Enums
{
    public class Contact
    {
        private string _number;

        private string _firstname;

        private string _surname;

        public Contact()
        {
        }

        public Contact(string firstname, string surname, string address, string number)
        {
            Surname = surname;
            Firstname = firstname;
            Number = number;
        }

        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = AssertStringContainsOnlyLetters("Surname", value);
            }
        }

        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = AssertStringContainsOnlyLetters("Firstname", value);
            }
        }

        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                if(!long.TryParse(value, out long num))
                {
                    throw new System.ArgumentException("value of the number field must consist of digits only");
                }
                if (value.Length != 11)
                {
                    throw new System.ArgumentException("value of the number field must consist of 11 digits");
                }
                _number = value;
            }
        }

        private string AssertStringContainsOnlyLetters(string stringProperty,string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new System.ArgumentException($"{stringProperty} must consist of English characters");
                }
            }
            return value;
        }
    }
}
