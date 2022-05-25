namespace Programming.Model
{
    public class Rectangle
    {
        private static int _allRectanglesCount;

        private int  _length;

        private int _width;

        private int _id;

        public Rectangle(Rectangle rectangle)
        {
            Id = rectangle.Id;
            Length = rectangle.Length;
            Width = rectangle.Width;
            Color = rectangle.Color;
            Center = new Point2D(rectangle.Center.X, rectangle.Center.Y);
        }

        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Rectangle(int length, int width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        public Point2D Center { get; set; }

        public string Color { get; set; }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public static int AllRectanglesCount
        {
            get 
            {
                return _allRectanglesCount;
            }
        }

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
