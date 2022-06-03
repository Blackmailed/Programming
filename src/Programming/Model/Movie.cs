using System;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Дата релиза.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _durationMinutes;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {        

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="releaseYear">Год релиза фильма. Должно быть в диапазоне от 1900 до 2022 (включительно).</param>
        /// <param name="durationMinutes">Продолжительность фильма в минутах. Должно быть положительным числом.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 0 до 10 (включительно).</param>
        /// <param name="name">Название фильма.</param>
        /// <param name="genre">Жанр фильма.</param>
        public Movie(int releaseYear, int durationMinutes, int rating,string name,string genre)
        {
            ReleaseYear = releaseYear;
            DurationMinutes = durationMinutes;
            Rating = rating;
            Name = name;
            Genre = genre;
        }

        /// <summary>
        /// Возвращает и задает назание фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма в минутах.
        /// Должна состоять только из цифр.
        /// </summary>
        public int DurationMinutes
        {
            get
            {
                return _durationMinutes;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(DurationMinutes), value);
                _durationMinutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает релиз фильма.
        /// Должна находится в диапазоне от 1950 до 2022(включительно).
        /// </summary>
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1950, DateTime.Now.Year);
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма.
        /// Должен находится в диапазоне от 0 до 10(включительно).
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0, 10);
                _rating = value;
            }
        }
    }
}
