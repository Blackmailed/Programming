namespace Programming.Model.Enums
{
    public class Rectangle
    {
        private double _length;
        private double _width;


        public Rectangle()
        {
        }

        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        public string Color { get; set; }

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value <= 0)
                {
                    throw new System.ArgumentException(
                        "the value of the height field must be positive");
                }
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
                if (value <= 0)
                {
                    throw new System.ArgumentException(
                        "the value of the width field must be positive");
                }
                _width = value;
            }
        }
    }
}
