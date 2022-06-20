namespace Programming.Model

{
    /// <summary>
    /// Хранит данные о контакте.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Номер.
        /// </summary>
        private string _number;

        // <summary>
        /// Имя.
        /// </summary>
        private string _firstname;

        // <summary>
        /// Фамилия.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="firstname">Имя. Должно состоять только из букв английского алфавита.</param>
        /// <param name="surname">Фамилия. Должна состоять только из букв английского алфавита.</param>
        /// <param name="number">Номер. Должен состоять только из цифр и иметь одиннадцать символов.</param>
        public Contact(string firstname, string surname, string number)
        {
            Surname = surname;
            Firstname = firstname;
            Number = number;
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта.
        /// Должна состоять только из букв английского алфавита.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = Validator.AssertStringContainsOnlyLetters(nameof(Surname), value);
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// Должно состоять только из букв английского алфавита.
        /// </summary>
        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = Validator.AssertStringContainsOnlyLetters(nameof(Firstname), value);
            }
        }

        /// <summary>
        /// Возвращает и задает номер контакта.
        /// Проверяет состоит ли номер только из цифр.
        /// Проверяет состоит ли номер из одиннадцати символов.
        /// </summary>
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
    }
}
