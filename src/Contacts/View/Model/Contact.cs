using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Хранит имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Хранит номер телефона контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Хранит электронную почту контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="_name">Имя контакта.</param>
        /// <param name="_phoneNumber">Номер телефона контакта.</param>
        /// <param name="_email">Адрес электронной почты контакта.</param>
        public Contact(string _name, string _phoneNumber, string _email)
        {
            Name = _name;
            PhoneNumber = _phoneNumber;
            Email = _email;
        }

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает адрес электронной почты контакта.
        /// </summary>
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