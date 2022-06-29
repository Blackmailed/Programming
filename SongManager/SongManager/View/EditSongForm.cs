using System;
using System.Windows.Forms;
using SongManager.Model;

namespace SongManager.View
{
    /// <summary>
    /// Предоставляет реализацию по представлению дочернего окна.
    /// </summary>
    public partial class EditSongForm : Form
    {
        /// <summary>
        /// Песня.
        /// </summary>
        private Song _song;

        private Song _song1;

        /// <summary>
        /// Возвращает и задаёт песню.
        /// </summary>
        public Song Song
        {
            get => _song1;
            set 
            {
                _song1 = value;
                SongNameTextBox.Text = _song1.SongName;
                ArtistNameTextBox.Text = _song1.ArtistName;
                DurationSecondsTextBox.Text = _song1.DurationSeconds.ToString();
                GenreComboBox.SelectedItem = _song1.Genre;
            }
        }

        public EditSongForm()
        {
            InitializeComponent();

            var genre = Enum.GetValues(typeof(Genre));

            foreach (var value in genre)
                GenreComboBox.Items.Add(value);

            //_song = SongData.Song;

            //_song = Song;

            //InsertInformationTextboxes(_song);
        }

        private void ClearFields()
        {
            SongNameTextBox.Clear();
            ArtistNameTextBox.Clear();
            DurationSecondsTextBox.Clear();
            GenreComboBox.Items.Clear();
        }

        //private void InsertInformationTextboxes(Song song)
        //{
        //    SongNameTextBox.Text = song.SongName;
        //    ArtistNameTextBox.Text = song.ArtistName;
        //    DurationSecondsTextBox.Text = song.DurationSeconds.ToString();
        //    GenreComboBox.SelectedItem = song.Genre;
        //}

        public bool IsCorrection()
        {
            return (SongNameTextBox.BackColor == AppColors.CorrectColor) &&
                   (ArtistNameTextBox.BackColor == AppColors.CorrectColor) &&
                   (DurationSecondsTextBox.BackColor == AppColors.CorrectColor);
        }

        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string songNameText = SongNameTextBox.Text;
                _song1.SongName = songNameText;
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
                _song1.ArtistName = artistNameText;
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
                _song1.DurationSeconds = durationSecondsValue;
            }
            catch
            {
                DurationSecondsTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            DurationSecondsTextBox.BackColor = AppColors.CorrectColor;
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _song1.Genre = (Genre)GenreComboBox.SelectedItem;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (IsCorrection())
            {
                SongData.Song = _song1;
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
            ClearFields();
            Close();
        }
    }
}
