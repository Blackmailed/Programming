using ObjectOrientedPractics.Services;
namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о товаре.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Количество товаров.
        /// </summary>
        private static int _allItemsCount;

        /// <summary>
        /// Название товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Информация о товаре
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            _allItemsCount++;
            _id = _allItemsCount;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Возвращает и задаёт название товара. Должно быть не более 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Name), 1, 200, value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт информацию о товаре. Должно быть не более 1000 символов.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Info), 1, 1000, value);
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт цену товара. Должно быть от 0 до 100000.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Cost), 0, 100000, value);
                _cost = value;
            }
        }
        /// <summary>
        ///Создает экземпляр класса <see cref="Item"/>
        /// </summary>
        /// <param name="name">Название товара</param>
        /// <param name="info">Информация о товаре</param>
        /// <param name="cost">Цена товара</param>
        /// <param name="category">Категория товара</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }
    }
}
