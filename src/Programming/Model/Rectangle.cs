namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }

        public Point2D Center { get; set; }

        public string Color { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue("the value of the height", value);
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue("the value of the width", value);
                _width = value;
            }
        }
    }
}
