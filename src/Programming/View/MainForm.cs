using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.View;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (var target in Enum.GetValues(typeof(Seasons)))
            {
                SeasonComboBox.Items.Add(target);
            }
            foreach (Enum valueEnums in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(valueEnums);
            }
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array enumValue;
            ValuesListBox.Items.Clear();
            
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Colors":
                    enumValue = Enum.GetValues(typeof(Colors));
                    foreach (Colors valve in enumValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Study":
                    enumValue = Enum.GetValues(typeof(Study));
                    foreach (Study valve in enumValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Genre":
                    enumValue = Enum.GetValues(typeof(Genre));
                    foreach (Genre valve in enumValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Seasons":
                    enumValue = Enum.GetValues(typeof(Seasons));
                    foreach (Seasons valve in enumValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Manufacturers":
                    enumValue = Enum.GetValues(typeof(Manufacturers));
                    foreach (Manufacturers valve in enumValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Weekday":
                    enumValue = Enum.GetValues(typeof(Weekday));
                    foreach (Weekday valve in enumValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

            }
        }
        private void ValuesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntTextBox.Text = ((int) item).ToString();
        }

        private void ParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(BoxWeekday.Text, out day))
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
            
            var target = (Seasons)SeasonComboBox.SelectedItem;
            switch (target)
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

        //private void ValuesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        //{

        //    var item = ValuesListBox.SelectedItem;
        //    var temp = (int)item;
        //    IntTextBox.Text = Convert.ToString(temp);
        //}
    }
}








//switch (EnumsListBox.SelectedItem)
//{
//    case View.Enums.Colors:
//        ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Colors)));

//        break;
//    case View.Enums.Study:
//        ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Study)));

//        break;
//    case View.Enums.Genre:
//        foreach (var Values in )
//            ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Genre)));

//        break;
//    case View.Enums.Seasons:
//        ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Seasons)));

//        break;
//    case View.Enums.Manufacturers:
//        ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Manufacturers)));


//        break;
//    case View.Enums.Weekday:
//        ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Weekday)));

//        break;

//}