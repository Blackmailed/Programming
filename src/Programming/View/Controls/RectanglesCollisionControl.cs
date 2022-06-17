using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Rectangle;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация представления прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles;

        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Коллекция отображаемых прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();

            _rectanglePanels = new List<Panel>();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                int indexSelectedRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[indexSelectedRectangle];
                LengthTextBox2.Text = _currentRectangle.Length.ToString();
                WidthTextBox2.Text = _currentRectangle.Width.ToString();
                XtextBox2.Text = _currentRectangle.Center.X.ToString();
                YtextBox2.Text = _currentRectangle.Center.Y.ToString();
                IdTextBox2.Text = _currentRectangle.Id.ToString();
            }
        }

        /// <summary>
        /// Из данных прямоугольника задаются параметры.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string RectangleInfo(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                $"(X={rectangle.Center.X}; " +
                $"Y={rectangle.Center.Y}; " +
                $"W={rectangle.Width}; " +
                $"L={rectangle.Length})";
        }

        /// <summary>
        /// Очищает информацию из списка и текстовых полей.
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectanglesListBox.Items.Clear();
            IdTextBox2.Clear();
            XtextBox2.Clear();
            YtextBox2.Clear();
            WidthTextBox2.Clear();
            LengthTextBox2.Clear();
            XtextBox2.BackColor = AppColors.CorrectColor;
            YtextBox2.BackColor = AppColors.CorrectColor;
            WidthTextBox2.BackColor = AppColors.CorrectColor;
            LengthTextBox2.BackColor = AppColors.CorrectColor;
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их.
        /// </summary>
        private void FindCollisions()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                CanvasPanel.Controls[k].BackColor = AppColors.IsNotCollisionColor;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.IsCollisionColor;
                        CanvasPanel.Controls[j].BackColor = AppColors.IsCollisionColor;
                    }
                }
            }
        }

        /// <summary>
        /// Обновляет информацию на панели.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location = new Point(rectangle.Center.X, rectangle.Center.Y);
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location = new Point(rectangle.Center.X, rectangle.Center.Y);
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Width = rectangle.Width;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Height = rectangle.Length;
                FindCollisions();
            }
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            RectanglesListBox.Items.Add(RectangleInfo(rectangle));
            _rectangles.Add(rectangle);

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = Convert.ToInt32(rectangle.Width);
            rectanglePanel.Height = Convert.ToInt32(rectangle.Length);
            rectanglePanel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.IsNotCollisionColor;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            if (_rectangles.Count > 0)
            {
                if (RectanglesListBox.SelectedIndex == -1) return;
                int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
                _rectangles.RemoveAt(selectedIndexRectangle);
                CanvasPanel.Controls.RemoveAt(selectedIndexRectangle);
                _rectanglePanels.RemoveAt(selectedIndexRectangle);
                ClearRectangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    RectanglesListBox.Items.Add(RectangleInfo(_rectangles[i]));
                    RectanglesListBox.SelectedIndex = 0;
                }
                FindCollisions();
            }
        }

        private void XtextBox2_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string xRectangleAsString = XtextBox2.Text;
                int rectangleX = int.Parse(xRectangleAsString);
                _currentRectangle.Center.X = rectangleX;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleInfo(_currentRectangle);
            }

            catch
            {
                XtextBox2.BackColor = AppColors.ErrorColor;
                return;
            }
            XtextBox2.BackColor = AppColors.CorrectColor;
        }

        private void YtextBox2_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string yRectangleAsString = YtextBox2.Text;
                int rectangleY = int.Parse(yRectangleAsString);
                _currentRectangle.Center.Y = rectangleY;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleInfo(_currentRectangle);
            }
            catch
            {
                YtextBox2.BackColor = AppColors.ErrorColor;
                return;
            }
            YtextBox2.BackColor = AppColors.CorrectColor;
        }

        private void WidthTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rectangleWidth = int.Parse(WidthTextBox2.Text);
                _currentRectangle.Width = rectangleWidth;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthTextBox2.BackColor = AppColors.ErrorColor;
                return;
            }
            WidthTextBox2.BackColor = AppColors.CorrectColor;
        }

        private void LengthTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string rectangleLength = LengthTextBox2.Text;
                _currentRectangle.Length = int.Parse(rectangleLength);
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleInfo(_currentRectangle);

            }
            catch
            {
                LengthTextBox2.BackColor = AppColors.ErrorColor;
                return;
            }
            LengthTextBox2.BackColor = AppColors.CorrectColor;
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
    }
}