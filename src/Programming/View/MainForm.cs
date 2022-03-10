using System;
using System.Windows.Forms;
using Programming.Model;
using Programming.View;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (Enum valueEnums in Enum.GetValues(typeof(Enums)))
            {
                EnumsListBox.Items.Add(valueEnums);
            }
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array EnunValue;
            ValuesListBox.Items.Clear();
            
            switch (EnumsListBox.SelectedItem.ToString())
            {
                case "Colors":
                    EnunValue = Enum.GetValues(typeof(Colors));
                    foreach (Colors valve in EnunValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Study":
                    EnunValue = Enum.GetValues(typeof(Study));
                    foreach (Study valve in EnunValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Genre":
                    EnunValue = Enum.GetValues(typeof(Genre));
                    foreach (Genre valve in EnunValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Seasons":
                    EnunValue = Enum.GetValues(typeof(Seasons));
                    foreach (Seasons valve in EnunValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Manufacturers":
                    EnunValue = Enum.GetValues(typeof(Manufacturers));
                    foreach (Manufacturers valve in EnunValue)
                    {
                        ValuesListBox.Items.Add(valve);
                    }
                    break;

                case "Weekday":
                    EnunValue = Enum.GetValues(typeof(Weekday));
                    foreach (Weekday valve in EnunValue)
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

        //private void ValuesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        //{

        //    var item = ValuesListBox.SelectedItem;
        //    var temp = (int)item;
        //    IntTextBox.Text = Convert.ToString(temp);
        //}
    }
}



//var item = ValuesListBox.SelectedItem;
//IntTextBox.Text = ((int)item).ToString();







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