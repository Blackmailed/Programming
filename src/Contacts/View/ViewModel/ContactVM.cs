using System;
using CommunityToolkit.Mvvm.ComponentModel;
using View.Model;

namespace View.ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>
    /// </summary>
    public class ContactVM : ObservableObject, ICloneable
    {
        /// <summary>
        /// Возвращает и получает объект класса <see cref="Model.Contact"/>
        /// </summary>
        public Contact Contact { get; }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact">Объект класса <see cref="Model.Contact"/>.</param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        ///  Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get => Contact.Name;
            set => SetProperty(
                Contact.Name,
                value,
                Contact,
                (contact, name) => Contact.Name = name);
        }

        /// <summary>
        ///  Возвращает и задаёт электронную почту контакта.
        /// </summary>
        public string Email
        {
            get => Contact.Email;
            set => SetProperty(
                Contact.Email,
                value,
                Contact,
                (contact, email) => Contact.Email = email);
        }

        /// <summary>
        ///  Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => Contact.PhoneNumber;
            set => SetProperty(
                Contact.PhoneNumber,
                value,
                Contact,
                (contact, phoneNumber) => Contact.PhoneNumber = phoneNumber);
        }

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}