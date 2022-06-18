using System;
using Color = Programming.Model.Enums.Colors;

namespace Programming.Model
{
    /// <summary>
    /// Хранит методы для создания прямоугольников.
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Максимальное значение ширины прямоугольника.
        /// </summary>
        private const int MaxRectangleWidth = 150;

        /// <summary>
        /// Максимальное значение длины прямоугольника.
        /// </summary>
        private const int MaxRectangleLength = 150;

        /// <summary>
        /// Минимальное значение ширины прямоугольника.
        /// </summary>
        private const int MinRectangleWidth = 5;

        /// <summary>
        /// Минимальное значение длины прямоугольника.
        /// </summary>
        private const int MinRectangleLength = 5;

        /// <summary>
        /// объявление экземпляра класса генерации рандомных чисел.
        /// Для генерации случайных чисел
        /// </summary>
        private static Random _random = new Random();

        ///// <summary>
        ///// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        ///// </summary>
        ///// <returns>Возвращает объект Rectangle.</returns>
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

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями высоты, ширины и координат.
        /// </summary>
        /// <param name="widthCanvas">Ширина элемента размещения.</param>
        /// <param name="lengthCanvas">Высота элемента размещения.</param>
        /// <returns>Возвращает объект Rectangle.</returns>
        public static Rectangle Randomize(int widthCanvas, int lengthCanvas)
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(MinRectangleWidth, MaxRectangleWidth);
            rectangle.Length = _random.Next(MinRectangleLength, MaxRectangleLength);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width - Margin),
                                           _random.Next(Margin, lengthCanvas - rectangle.Length - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}
