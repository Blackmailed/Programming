using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using Movie = Programming.Model.Movie;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Предоставляет реализацию по представлению фильмов.
    /// </summary>
    public partial class MovieControl : UserControl
    {
        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Текущий фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// объявление экземпляра класса генерации рандомных чисел.
        /// Для генерации случайных чисел
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MovieControl()
        {
            InitializeComponent();
            InitMovie();
        }

        /// <summary>
        /// Инициализирует массив фильмов.
        /// </summary>
        private void InitMovie()
        {
            _movies = new Movie[5];
            string[] films = new string[5] {
                "The Boondock Saints", "Snatch", "Zodiac", "Catch Me If You Can", "Legend" };
            var genre = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < 5; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.ReleaseYear = _random.Next(1950, DateTime.Now.Year);
                _currentMovie.Genre = genre.GetValue(_random.Next(0, genre.Length)).ToString();
                _currentMovie.Rating = _random.Next(1, 11);
                _currentMovie.DurationMinutes = _random.Next(1, 180);
                _currentMovie.Name = films[i];
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MovieListBox.SelectedIndex];
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            YearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            DurationTextBox.Text = _currentMovie.DurationMinutes.ToString();
            NameTextBox.Text = _currentMovie.Name.ToString();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = NameTextBox.Text;
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int yearMovie = int.Parse(YearTextBox.Text);
                _currentMovie.ReleaseYear = yearMovie;
            }
            catch
            {
                YearTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            YearTextBox.BackColor = AppColors.CorrectColor;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int ratingMovie = int.Parse(RatingTextBox.Text);
                _currentMovie.Rating = ratingMovie;
            }
            catch
            {
                RatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RatingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int movieDuration = int.Parse(DurationTextBox.Text);
                _currentMovie.DurationMinutes = movieDuration;
            }
            catch
            {
                DurationTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            DurationTextBox.BackColor = AppColors.CorrectColor;
        }

        /// <summary>
        /// Находит фильм с наивысшим рейтингом.
        /// </summary>
        /// <param name="movies">Коллекция фильмов.</param>
        /// <returns>Возвращает индекс элемента коллекции, чей рейтинг больше остальных.</returns>
        private int FindMaxRating(Movie[] movie)
        {
            int maxRatingIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < 5; i++)
            {
                if (movie[i].Rating > maxValue)
                {
                    maxValue = movie[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void FindRatingButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMaxRating(_movies);
        }
    }
}
