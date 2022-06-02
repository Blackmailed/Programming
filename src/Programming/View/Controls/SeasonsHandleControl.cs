using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model;

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
                    this.BackColor = AppColors.Winter;
                    MessageBox.Show("«Бррр! Холодно!!»", "AlErT", MessageBoxButtons.OKCancel);
                    break;
                case Seasons.Spring:
                    this.BackColor = AppColors.Spring;
                    break;
                case Seasons.Summer:
                    this.BackColor = AppColors.Summer;
                    MessageBox.Show("«Ура! Солнце!!»", "AlErT", MessageBoxButtons.OKCancel);
                    break;
                case Seasons.Autumn:
                    this.BackColor = AppColors.Autumn;
                    break;
            }
        }
    }
}
