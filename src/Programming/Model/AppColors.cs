using System.Drawing;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные об используемых цветах.
    /// </summary>
    public class AppColors
    {
        /// <summary>
        /// Цвет пересекающихся фигур.
        /// </summary>
        public static Color IsCollisionColor = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет не пересекающихся фигур.
        /// </summary>
        public static Color IsNotCollisionColor = Color.FromArgb(127, 127, 255, 127);

        /// <summary>
        /// Цвет ошибкочного значение.
        /// </summary>
        public static Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static Color CorrectColor = Color.White;

        /// <summary>
        /// Цвет для обозначения Spring.
        /// </summary>
        public static Color SpringColor = Color.FromArgb(226, 215, 69);

        /// <summary>
        /// Цвет для обозначение Autumn.
        /// </summary>
        public static Color AutumnColor = Color.FromArgb(226, 156, 69);

        /// <summary>
        /// Цвет для обозначения Winter.
        /// </summary>
        public static Color WinterColor = Color.FromArgb(69, 83, 226);

        /// <summary>
        /// Цвет для обозначения Summer.
        /// </summary>
        public static Color SummerColor = Color.FromArgb(85, 156, 69);
    }
}
