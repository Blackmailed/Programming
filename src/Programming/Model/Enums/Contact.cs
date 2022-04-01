using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Enums
{
    class Contact
    {
        private string _number;

        public Contact()
        {
        }

        public Contact(string firstname, string surname, string address, string number)
        {
            Firstname = firstname;
            Surname = surname;
            Number = number;
        }
        public string Firstname { get; set; }
        public string Surname{ get; set; }
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
                    throw new System.ArgumentException("the value of the number field must consist of 11 digits");
                }
                _number = value;
            }
        }
    }
}
