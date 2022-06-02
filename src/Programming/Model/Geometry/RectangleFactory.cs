using System;
using Color = Programming.Model.Enums.Colors;

namespace Programming.Model
{
    public class RectangleFactory
    {
        private const int Margin = 15;

        private const int MaxRectangleWidth = 150;

        private const int MaxRectangleLength = 150;

        private const int MinRectangleWidth = 5;

        private const int MinRectangleLength = 5;

        private static Random _random = new Random();

        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(1, 300), _random.Next(1, 300));
            rectangle.Width = _random.Next(30, 101);
            rectangle.Length = _random.Next(30, 101);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }

        public static Rectangle Randomize(int widthCanvas, int lengthCanvas)
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(MinRectangleWidth, MaxRectangleWidth);
            rectangle.Length = _random.Next(MinRectangleLength, MaxRectangleLength);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width - Margin),
                                           _random.Next(Margin, lengthCanvas - rectangle.Width - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}
