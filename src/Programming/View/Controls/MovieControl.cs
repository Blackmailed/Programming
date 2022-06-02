﻿using System;
using System.Windows.Forms;
using Programming.Model.Enums;
using Movie = Programming.Model.Movie;

namespace Programming.View.Controls
{
    public partial class MovieControl : UserControl
    {
        private Movie[] _movies;

        private Movie _currentMovie;

        private Random _random = new Random();

        private readonly System.Drawing.Color _errorColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color _correctColor = System.Drawing.Color.White;

        public MovieControl()
        {
            InitializeComponent();
            InitMovie();
        }

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
                YearTextBox.BackColor = _errorColor;
                return;
            }
            YearTextBox.BackColor = _correctColor;
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
                RatingTextBox.BackColor = _errorColor;
                return;
            }
            RatingTextBox.BackColor = _correctColor;
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
                DurationTextBox.BackColor = _errorColor;
                return;
            }
            DurationTextBox.BackColor = _correctColor;
        }

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