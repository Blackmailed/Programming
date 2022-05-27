using System;
using Programming.Model;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using System.Collections.Generic;
using Rectangle = Programming.Model.Rectangle;
using Movie = Programming.Model.Movie;
namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly System.Drawing.Color _errorColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color _correctColor = System.Drawing.Color.White;

        private readonly System.Drawing.Color Intersects = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        private readonly System.Drawing.Color unIntersects = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels;

        private Movie[] _movies;

        private Movie _currentMovie;

        private Random _random = new Random();

        public MainForm()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();

            _rectanglePanels = new List<Panel>();

            foreach (var season in Enum.GetValues(typeof(Seasons)))
            {
                SeasonComboBox.Items.Add(season);
            }
            foreach (Enum valueEnums in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(valueEnums);
            }
            EnumsListBox.SelectedIndex = 0;
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

        private int FindMaxWidth(List<Rectangle> rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < rectangles.Count; i++)
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

        private void FindCollisions()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                CanvasPanel.Controls[k].BackColor = unIntersects;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = Intersects;
                        CanvasPanel.Controls[j].BackColor = Intersects;
                    }
                }
            }
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
            if (RectanglesListBox.SelectedIndex != -1)
            {
                _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
                LengthTextBox.Text = _currentRectangle.Length.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                ColorTextBox.Text = _currentRectangle.Color;
                XtextBox.Text = _currentRectangle.Center.X.ToString();
                YtextBox.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void RectanglesListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex != -1)
            {
                int indexSelectedRectangle = RectanglesListBox2.SelectedIndex;
                _currentRectangle = _rectangles[RectanglesListBox2.SelectedIndex];
                LengthTextBox2.Text = _currentRectangle.Length.ToString();
                WidthTextBox2.Text = _currentRectangle.Width.ToString();
                XtextBox2.Text = _currentRectangle.Center.X.ToString();
                YtextBox2.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox2.Text = _currentRectangle.Id.ToString();
            }
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rectangleLength = int.Parse(LengthTextBox.Text);
                _currentRectangle.Length = rectangleLength;
                int index = RectanglesListBox2.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox2.Items[index] = RectangleInfo(_currentRectangle);
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
                int rectangleWidth = int.Parse(WidthTextBox.Text);
                _currentRectangle.Width = rectangleWidth;
                int index = RectanglesListBox2.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox2.Items[index] = RectangleInfo(_currentRectangle);
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
            string rectangleColor = ColorTextBox.Text;
            _currentRectangle.Color = rectangleColor;
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

        private void FindRatingButton_Click(object sender, EventArgs e)
        {
            MovieListBox.SelectedIndex = FindMaxRating(_movies);
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
            RectanglesListBox2.Items.Add(RectangleInfo(rectangle));
            _rectangles.Add(rectangle);

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = Convert.ToInt32(rectangle.Width);
            rectanglePanel.Height = Convert.ToInt32(rectangle.Length);
            rectanglePanel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = unIntersects;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            
            if (_rectangles.Count > 0)
            {
                if (RectanglesListBox2.SelectedIndex == -1) return;
                int selectedIndexRectangle = RectanglesListBox2.SelectedIndex;
                _rectangles.RemoveAt(selectedIndexRectangle);
                CanvasPanel.Controls.RemoveAt(selectedIndexRectangle);
                _rectanglePanels.RemoveAt(selectedIndexRectangle);
                ClearRectangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    RectanglesListBox2.Items.Add(RectangleInfo(_rectangles[i]));
                    RectanglesListBox2.SelectedIndex = 0;
                    RectanglesListBox.Items.Add($"Rectangle {_rectangles[i].Id}");
                    RectanglesListBox.SelectedIndex = 0;
                }
                FindCollisions();
            }
        }

        private string RectangleInfo(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                $"(X={rectangle.Center.X}; " +
                $"Y={rectangle.Center.Y}; " +
                $"W={rectangle.Width}; " +
                $"L={rectangle.Length})";
        }

        private void ClearRectangleInfo()
        {
            RectanglesListBox2.Items.Clear();
            IdTextBox2.Clear();
            XtextBox2.Clear();
            YtextBox2.Clear();
            WidthTextBox2.Clear();
            LengthTextBox2.Clear();
            XtextBox2.BackColor = _correctColor;
            YtextBox2.BackColor = _correctColor;
            WidthTextBox2.BackColor = _correctColor;
            LengthTextBox2.BackColor = _correctColor;
            RectanglesListBox.Items.Clear();
            ColorTextBox.Clear();
            IdTextBox.Clear();
            XtextBox.Clear();
            YtextBox.Clear();
            WidthTextBox.Clear();
            LengthTextBox.Clear();
            WidthTextBox.BackColor = _correctColor;
            LengthTextBox.BackColor = _correctColor;
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                CanvasPanel.Controls[RectanglesListBox2.SelectedIndex].Location = new Point(rectangle.Center.X, rectangle.Center.Y);
                CanvasPanel.Controls[RectanglesListBox2.SelectedIndex].Location = new Point(rectangle.Center.X, rectangle.Center.Y);
                CanvasPanel.Controls[RectanglesListBox2.SelectedIndex].Width = rectangle.Width;
                CanvasPanel.Controls[RectanglesListBox2.SelectedIndex].Height = rectangle.Length;
                FindCollisions();
            }
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RectanglesListBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex != -1)
            {
                int indexSelectedRectangle = RectanglesListBox2.SelectedIndex;
                _currentRectangle = _rectangles[indexSelectedRectangle];
                LengthTextBox2.Text = _currentRectangle.Length.ToString();
                WidthTextBox2.Text = _currentRectangle.Width.ToString();
                XtextBox2.Text = _currentRectangle.Center.X.ToString();
                YtextBox2.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox2.Text = _currentRectangle.Id.ToString();
            }
        }

        private void XtextBox2_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex == -1) return;

            try
            {
                string xRectangleAsString = XtextBox2.Text;
                int rectangleX = int.Parse(xRectangleAsString);
                _currentRectangle.Center.X = rectangleX;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox2.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox2.Items[index] = RectangleInfo(_currentRectangle);
            }

            catch
            {
                XtextBox2.BackColor = _errorColor;
                return;
            }
            XtextBox2.BackColor = _correctColor;
        }

        private void YtextBox2_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox2.SelectedIndex == -1) return;

            try
            {
                string yRectangleAsString = YtextBox2.Text;
                int rectangleY = int.Parse(yRectangleAsString);
                _currentRectangle.Center.Y = rectangleY;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox2.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox2.Items[index] = RectangleInfo(_currentRectangle);
            }
            catch
            {
                YtextBox2.BackColor = _errorColor;
                return;
            }
            YtextBox2.BackColor = _correctColor;
        }

        private void WidthTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rectangleWidth = int.Parse(WidthTextBox2.Text);
                _currentRectangle.Width = rectangleWidth;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox2.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox2.Items[index] = RectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthTextBox2.BackColor = _errorColor;
                return;
            }
            WidthTextBox2.BackColor = _correctColor;
        }

        private void LengthTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string rectangleLength = LengthTextBox2.Text;
                _currentRectangle.Length = int.Parse(rectangleLength);
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox2.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox2.Items[index] = RectangleInfo(_currentRectangle);
                
            }
            catch
            {
                LengthTextBox2.BackColor = _errorColor;
                return;
            }
            LengthTextBox2.BackColor = _correctColor;
        }
    }
}