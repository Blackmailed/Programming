namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные прямоугольника.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int  _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Уеникальный индентификатор.
        /// </summary>
        private int _id;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Высота. Должна быть положительным числом.</param>
        /// <param name="width">Ширина. Должна быть положительным числом.</param>
        /// <param name="color">Цвет.</param>
        /// <param name="center">Координаты центра.</param>
        public Rectangle(int length, int width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Возвращает и задаёт координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        /// <summary>
        /// Возвращает и задаёт длину прямоугольника. Должна быть положительным числом.
        /// </summary>
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Length), value);
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт ширину прямоугольника. Должна быть положительным числом.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }
    }
}
