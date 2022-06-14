using System;
using System.Windows.Forms;
using SongManager.Model;


namespace SongManager.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению дочернего окна.
    /// </summary>
    public partial class AddSongForm : Form
    {
        /// <summary>
        /// Песня.
        /// </summary>
        private Song _song;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddSongForm"/>.
        /// </summary>
        public AddSongForm()
        {
            InitializeComponent();

            _song = new Song();
            SongNameTextBox.Text = "Song name";
            ArtistNameTextBox.Text = "Artist name";
            DurationSecondsTextBox.Text = "100";
            var genre = Enum.GetValues(typeof(Genre));

            foreach (var value in genre)
                GenreComboBox.Items.Add(value);

            GenreComboBox.SelectedIndex = 0;
        }

        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string songNameText = SongNameTextBox.Text;
                _song.SongName = songNameText;
            }
            catch
            {
                SongNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            SongNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ArtistNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string artistNameText = ArtistNameTextBox.Text;
                _song.ArtistName = artistNameText;
            }
            catch
            {
                ArtistNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            ArtistNameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DurationSecondsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string durationSecondsText = DurationSecondsTextBox.Text;
                int durationSecondsValue = int.Parse(durationSecondsText);
                _song.DurationSeconds = durationSecondsValue;
            }
            catch
            {
                DurationSecondsTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            DurationSecondsTextBox.BackColor = AppColors.CorrectColor;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _song.Genre = (Genre)GenreComboBox.SelectedItem;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (IsCorrection(SongNameTextBox,
                    ArtistNameTextBox,
                    DurationSecondsTextBox))
            {
                SongData.Song = _song;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Incorrect values have been entered. Fix it and try again.", "Error");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static bool IsCorrection(TextBox textBox1,
                                        TextBox textBox2,
                                        TextBox textBox3)
        {
            return (textBox1.BackColor == AppColors.CorrectColor) &&
                   (textBox2.BackColor == AppColors.CorrectColor) &&
                   (textBox3.BackColor == AppColors.CorrectColor);
        }
    }
}
