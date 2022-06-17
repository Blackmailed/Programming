using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Реализация изменения цвета фона главного окна.
    /// </summary>
    public partial class SeasonsHandleControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonsHandleControl"/>.
        /// </summary>
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
                    BackColor = AppColors.WinterColor;
                    MessageBox.Show("«Бррр! Холодно!!»", "AlErT", MessageBoxButtons.OKCancel);
                    break;
                case Seasons.Spring:
                    BackColor = AppColors.SpringColor;
                    break;
                case Seasons.Summer:
                    BackColor = AppColors.SummerColor;
                    MessageBox.Show("«Ура! Солнце!!»", "AlErT", MessageBoxButtons.OKCancel);
                    break;
                case Seasons.Autumn:
                    BackColor = AppColors.AutumnColor;
                    break;
            }
        }
    }
}
