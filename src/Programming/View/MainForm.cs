using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Enums.Rectangle;
using Movie = Programming.Model.Enums.Movie;
namespace Programming.View

{
    public partial class MainForm : Form
    {
        private readonly System.Drawing.Color _errorColor = System.Drawing.Color.LightPink;
        private readonly System.Drawing.Color _correctColor = System.Drawing.Color.White;
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        private Movie[] _movie;
        private Movie _currentMovie;
        private Random _rand = new Random();


        private int FindMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
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

        public MainForm()
        {
            InitializeComponent();
            foreach (var season in Enum.GetValues(typeof(Seasons)))
            {
                SeasonComboBox.Items.Add(season);
            }
            foreach (Enum valueEnums in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(valueEnums);
            }
            EnumsListBox.SelectedIndex = 0;
            InitRectangles();
            InitMovie();
        }
        private void InitRectangles()
        {
            _rectangles = new Rectangle[5];
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < 5; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _rand.Next(50);
                _currentRectangle.Length = _rand.Next(50);
                _currentRectangle.Color = colors.GetValue(_rand.Next(0, colors.Length)).ToString();
                _rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            RectanglesListBox.SelectedIndex = 0;
        }

        private void InitMovie()
        {
            _movie = new Movie[5];
            string[] films = new string[5] {
                "The Boondock Saints", "Snatch", "Zodiac", "Catch Me If You Can", "Legend" };
            var genre = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < 5; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.ReleaseYear = _rand.Next(1950, DateTime.Now.Year);
                _currentMovie.Genre = genre.GetValue(_rand.Next(0, genre.Length)).ToString();
                _currentMovie.Rating = _rand.Next(1, 11);
                _currentMovie.DurationMinutes = _rand.Next(1, 180);
                _currentMovie.Name = films[i];
                _movie[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }


        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Enums)EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Colors));
                    break;
                case Enums.Genre:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Manufacturers:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Manufacturers));
                    break;
                case Enums.Seasons:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Seasons));
                    break;
                case Enums.Study:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Study));
                    break;
                case Enums.Weekday:
                    ValuesListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntTextBox.Text = ((int)item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            if (Enum.TryParse(WeekdayTextBox.Text, out weekday))
            {
                OutputLabel.Text = $"Это день недели ({weekday.ToString()} = {(int)weekday}).";
            }
            else
            {
                OutputLabel.Text = "Нет такого дня недели";
            }
        }

        private void SeasonGoButton_Click(object sender, EventArgs e)
        {
            var season = (Seasons)SeasonComboBox.SelectedItem;
            switch (season)
            {
                case Seasons.Winter:
                    BackColor = ColorTranslator.FromHtml("#4169E1");
                    MessageBox.Show("«Бррр! Холодно!!»", "AlErT", MessageBoxButtons.OKCancel);
                    break;
                case Seasons.Spring:
                    BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Seasons.Summer:
                    BackColor = ColorTranslator.FromHtml("#FFD700");
                    MessageBox.Show("«Ура! Солнце!!»", "AlErT", MessageBoxButtons.OKCancel);
                    break;
                case Seasons.Autumn:
                    BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double lengthRectangle = double.Parse(LengthTextBox.Text);
                _currentRectangle.Length = lengthRectangle;
            }
            catch
            {
                LengthTextBox.BackColor = _errorColor;
                return;
            }
            LengthTextBox.BackColor = _correctColor;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double widthRectangle = double.Parse(WidthTextBox.Text);
                _currentRectangle.Width = widthRectangle;
            }
            catch
            {
                WidthTextBox.BackColor = _errorColor;
                return;
            }
            WidthTextBox.BackColor = _correctColor;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
                string colorRectangleValue = ColorTextBox.Text;
                _currentRectangle.Color = colorRectangleValue;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movie[MovieListBox.SelectedIndex];
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
                int ratingMovie= int.Parse(RatingTextBox.Text);
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
                int durationMovie = int.Parse(DurationTextBox.Text);
                _currentMovie.DurationMinutes = durationMovie;
            }
            catch
            {
                DurationTextBox.BackColor = _errorColor;
                return;
            }
            DurationTextBox.BackColor = _correctColor;
        }

        private void FindRatingButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMaxRating(_movie);
        }
    }
}