using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.View;
namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (var Season in Enum.GetValues(typeof(Seasons)))
            {
                SeasonComboBox.Items.Add(Season);
            }
            foreach (Enum valueEnums in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(valueEnums);
            }
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array valueEnums;
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Colors":
                    valueEnums = Enum.GetValues(typeof(Colors));
                    foreach (Colors valve in valueEnums)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;
                case "Study":
                    valueEnums = Enum.GetValues(typeof(Study));
                    foreach (Study valve in valueEnums)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;
                case "Genre":
                    valueEnums = Enum.GetValues(typeof(Genre));
                    foreach (Genre valve in valueEnums)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;
                case "Seasons":
                    valueEnums = Enum.GetValues(typeof(Seasons));
                    foreach (Seasons valve in valueEnums)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;
                case "Manufacturers":
                    valueEnums = Enum.GetValues(typeof(Manufacturers));
                    foreach (Manufacturers valve in valueEnums)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;
                case "Weekday":
                    valueEnums = Enum.GetValues(typeof(Weekday));
                    foreach (Weekday valve in valueEnums)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntTextBox.Text = ((int) item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(WeekdayBox.Text, out day))
            {
                OutputLabel.Text = $"Это день недели ({day.ToString()} = {(int)day}).";
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
    }
}