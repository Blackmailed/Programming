using System;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class WeekdayParsinControl : UserControl
    {
        public WeekdayParsinControl()
        {
            InitializeComponent();
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
    }
}
