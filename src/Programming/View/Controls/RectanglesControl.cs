using System.Windows.Forms;
using Programming.Model;
using System.Collections.Generic;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        public RectanglesControl()
        {
            InitializeComponent();
            _rectangles = CreateRectangles();
            RectanglesListBox.SelectedIndex = 0;
        }

        private Rectangle[] CreateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[5];
            for (int i = 0; i < 5; i++)
            {
                _currentRectangle = RectangleFactory.Randomize();
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            } 
            return rectangles;
        }


        private void RectanglesListBox_SelectedIndexChanged(object sender, System.EventArgs e)
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

        private void LengthTextBox_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                int rectangleLength = int.Parse(LengthTextBox.Text);
                _currentRectangle.Length = rectangleLength;
            }
            catch
            {
                LengthTextBox.BackColor = AppColors._errorColor;
                return;
            }
            LengthTextBox.BackColor = AppColors._correctColor;
        }

        private void WidthTextBox_TextChanged(object sender, System.EventArgs e)
        {
            try
            {
                int rectangleWidth = int.Parse(WidthTextBox.Text);
                _currentRectangle.Width = rectangleWidth;
            }
            catch
            {
                WidthTextBox.BackColor = AppColors._errorColor;
                return;
            }
            WidthTextBox.BackColor = AppColors._correctColor;
        }

        private void ColorTextBox_TextChanged(object sender, System.EventArgs e)
        {
            string rectangleColor = ColorTextBox.Text;
            _currentRectangle.Color = rectangleColor;
        }

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

        private void FindWidthButton_Click(object sender, System.EventArgs e)
        {
            int findMaxWidthIndex = FindMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }
    }
}
