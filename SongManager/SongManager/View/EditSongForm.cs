﻿using System;
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

        public EditSongForm()
        {
            InitializeComponent();

            var genre = Enum.GetValues(typeof(Genre));

            foreach (var value in genre)
                GenreComboBox.Items.Add(value);

            _song = SongData.Song;

            InsertInformationTextboxes(_song);
        }

        private void InsertInformationTextboxes(Song song)
        {
            SongNameTextBox.Text = song.SongName;
            ArtistNameTextBox.Text = song.ArtistName;
            DurationSecondsTextBox.Text = song.DurationSeconds.ToString();
            GenreComboBox.SelectedItem = song.Genre;
        }

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

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _song.Genre = (Genre)GenreComboBox.SelectedItem;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (IsCorrection())
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
    }
}
