using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Rectangle;
using Programming.Model;

namespace Programming.View.Controls
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private readonly System.Drawing.Color _errorColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color _correctColor = System.Drawing.Color.White;

        private readonly System.Drawing.Color Intersects = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        private readonly System.Drawing.Color unIntersects = System.Drawing.Color.FromArgb(127, 127, 255, 127);

        private List<Rectangle> _rectangles;

        private Rectangle _currentRectangle;

        private List<Panel> _rectanglePanels;

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();

            _rectanglePanels = new List<Panel>();
        }

        private void RectanglesListBox2_SelectedIndexChanged(object sender, EventArgs e)
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

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
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
                }
                FindCollisions();
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