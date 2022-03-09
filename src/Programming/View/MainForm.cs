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
            ValuesListBox.Items.Clear();
            
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Colors:
                    ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Colors)));

                    break;
                case "Study":
                    ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Study)));

                    break;
                case "Genre":
                    ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Genre)));

                    break;
                case "Seasons":
                    ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Seasons)));

                    break;
                case "Manufacturers":
                    ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Manufacturers)));


                    break;
                case "Weekday":
                    ValuesListBox.Items.AddRange(items: Enum.GetNames(typeof(Weekday)));

                    break;

            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntTextBox.Text = Convert.ToString((int)item);
        }

        private void ValuesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
