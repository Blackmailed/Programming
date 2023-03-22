using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    public class Contact
    {
        private string _name;

        private string _phoneNumber;

        private string _email;

        public Contact()
        {

        }

        public Contact(string _name, string _phoneNumber, string _email)
        {
            Name = _name;
            PhoneNumber = _phoneNumber;
            Email = _email;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
    }
}