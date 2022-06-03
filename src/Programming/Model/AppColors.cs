using System.Drawing;


namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об используемых цветах.
    /// </summary>
    class AppColors
    {
        /// <summary>
        /// Цвет пересекающихся фигур.
        /// </summary>
        public static Color Intersects = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет не пересекающихся фигур.
        /// </summary>
        public static Color unIntersects = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет ошибкочного значение.
        /// </summary>
        public static Color _errorColor = Color.LightPink;

        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static Color _correctColor = Color.White;

        /// <summary>
        /// Цвет для обозначения Spring.
        /// </summary>
        public static Color Spring = Color.FromArgb(226, 215, 69);

        /// <summary>
        /// Цвет для обозначение Autumn.
        /// </summary>
        public static Color Autumn = Color.FromArgb(226, 156, 69);

        /// <summary>
        /// Цвет для обозначения Winter.
        /// </summary>
        public static Color Winter = Color.FromArgb(69, 83, 226);

        /// <summary>
        /// Цвет для обозначения Summer.
        /// </summary>
        public static Color Summer = Color.FromArgb(85, 156, 69);

    }
}
