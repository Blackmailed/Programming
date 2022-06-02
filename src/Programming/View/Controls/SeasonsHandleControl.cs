using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class SeasonsHandleControl : UserControl
    {
        public SeasonsHandleControl()
        {
            InitializeComponent();
            foreach (var season in Enum.GetValues(typeof(Seasons)))
            {
                SeasonComboBox.Items.Add(season);
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
