using ObjectOrientedPractics.Services;
namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателе.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// ФИО покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес.
        /// </summary>
        private string _address;

        /// <summary>
        /// Количество покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт фИО. Должно быть не более 200 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullname;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(FullName), 1, 200, value);
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес. Должно быть не более 500 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Address), 1, 500, value);
                _address = value;
            }
        }

        /// <summary>
        ///Создает экземпляр класса <see cref="Customer"/>
        /// </summary>
        /// <param name="fullname"></param>
        /// <param name="address"></param>
        public Customer(string fullname, string address)
        {
            FullName = fullname;
            Address = address;
        }
    }
}
