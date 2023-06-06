using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using Model;

namespace ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>
    /// </summary>
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        /// Возвращает и получает объект класса <see cref="Model.Contact"/>
        /// </summary>
        public Contact Contact { get; set; }

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
        [CustomValidation(typeof(Model.Services.Validator), nameof(Model.Services.Validator.ValidateName))]
        public string Name
        {
            get => Contact.Name;
            set => SetProperty(
                Contact.Name,
                value,
                Contact,
                (contact, name) => Contact.Name = name, true);
        }

        /// <summary>
        ///  Возвращает и задаёт электронную почту контакта.
        /// </summary>
        [CustomValidation(typeof(Model.Services.Validator), nameof(Model.Services.Validator.ValidateEmail))]
        public string Email
        {
            get => Contact.Email;
            set => SetProperty(
                Contact.Email,
                value,
                Contact,
                (contact, email) => Contact.Email = email, true);
        }

        /// <summary>
        ///  Возвращает и задаёт номер телефона контакта.
        /// </summary>
        [CustomValidation(typeof(Model.Services.Validator), nameof(Model.Services.Validator.ValidatePhone))]
        public string PhoneNumber
        {
            get => Contact.PhoneNumber;
            set => SetProperty(
                Contact.PhoneNumber,
                value,
                Contact,
                (contact, phoneNumber) => Contact.PhoneNumber = phoneNumber, true);
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