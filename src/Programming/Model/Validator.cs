namespace Programming.Model
{
    /// <summary>
    /// Хранит методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="stringProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число. </param>
        /// <exception cref="System.ArgumentException">Выбрасывается, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string stringProperty, int value)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException($"{stringProperty} must be greater than zero");
            }
        }

        /// <summary>
        /// Проверяет, что число является положительным.
        /// </summary>
        /// <param name="stringProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string stringProperty, double value)
        {
            if (value <= 0)
            {
                throw new System.ArgumentException($"{stringProperty} must be greater than zero");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="stringProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(string stringProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{value} should be between {min} and {max}");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в определённом диапазоне.
        /// </summary>
        /// <param name="stringProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница диапазона.</param>
        /// <param name="max">Правая граница диапазона.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, если число находится вне диапазона.</exception>
        public static void AssertValueInRange(string stringProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new System.ArgumentException($"{value} should be between {min} and {max}");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="stringProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, если строка состоит не только из
        /// букв английского алфавита.</exception>
        public static string AssertStringContainsOnlyLetters(string stringProperty, string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (!char.IsLetter(value[i]))
                {
                    throw new System.ArgumentException(
                        $"{stringProperty} must consist of English characters");
                }
            }
            return value;
        }
    }
}
