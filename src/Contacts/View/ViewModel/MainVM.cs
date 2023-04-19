using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Контакт.
        /// </summary>
        public Contact Contact { get; private set; } = new Contact();

        /// <summary>
        /// Возвращает и задаёт путь сериализации. По умолчанию - папка "Мои документы".
        /// </summary>
        public string Path { get; set; } =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name
        {
            get
            { 
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return Contact.PhoneNumber;
            }
            set
            {
                Contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает и задает адрес электронной почты контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Команда сериализации контакта.
        /// </summary>
        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand((obj) =>
                {
                    ContactSerializer.Serialize(Contact, Path);
                });
            }
        }

        /// <summary>
        /// Команда десериализации контакта.
        /// </summary>
        public ICommand LoadCommand
        {
            get => new RelayCommand((obj) =>
            {
                var contact = ContactSerializer.Deserialize(Path);
                Name = contact.Name;
                Email = contact.Email;
                PhoneNumber = contact.PhoneNumber;
            });
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
