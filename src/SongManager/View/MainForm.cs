using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SongManager.Model;

namespace SongManager.View
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список песен.
        /// </summary>
        private List<Song> _songs;

        /// <summary>
        /// Выбранная песня.
        /// </summary>
        private Song _currentSong;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _songs = Serializer.Deserialize();

            var values = Enum.GetValues(typeof(Genre));
            foreach (var value in values)
            {
                GenreComboBox.Items.Add(value);
            }
            UpdateSongInfo();
        }

        /// <summary>
        /// Из данных песни преобразует текст.
        /// </summary>
        /// <param name="song">Песня.</param>
        /// <returns>Возвращает текст.</returns>
        private string SongInfo(Song song)
        {
            return $"{song.ArtistName} - {song.SongName}";
        }

        /// <summary>
        /// Обновляет информацию в списке при изменении значений.
        /// </summary>
        private void UpdateSongInfo()
        {
            SongsListBox.Items.Clear();

            _songs = SongServices.SortSongs(_songs);
            foreach (var value in _songs)
            {
                SongsListBox.Items.Add(SongInfo(value));
            }
            var index = _songs.IndexOf(_currentSong);
            SongsListBox.SelectedIndex = Convert.ToInt32(index);
        }

        /// <summary>
        /// Очищает информацию с текстовых полей.
        /// </summary>
        public void ClearSongInfo()
        {
            SongNameTextBox.Clear();
            ArtistNameTextBox.Clear();
            DurationSecondsTextBox.Clear();
        }

        private void AddSongButton_Click(object sender, EventArgs e)
        {
            _currentSong = SongServices.DefaultInfo();

            _songs.Add(_currentSong);
            SongsListBox.Items.Add(SongInfo(_currentSong));
            SongServices.SortSongs(_songs);
            UpdateSongInfo();

            SongsListBox.SelectedIndex = _songs.Count - 1;
        }

        private void RemoveSongButton_Click(object sender, EventArgs e)
        {
            int index = SongsListBox.SelectedIndex;

            if (index != -1)
            {
                _songs.RemoveAt(index);
                SongsListBox.Items.RemoveAt(index);
                ClearSongInfo();

                for (int i = 0; i < _songs.Count; i++)
                {
                    SongsListBox.Items.Add(SongInfo(_songs[i]));
                    SongsListBox.SelectedIndex = 0;
                }
            }
            UpdateSongInfo();

            Serializer.Serialize(_songs);
        }

        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedIndex != -1)
            {
                int indexSong = SongsListBox.SelectedIndex;
                _currentSong = _songs[indexSong];
                SongNameTextBox.Text = _currentSong.SongName;
                ArtistNameTextBox.Text = _currentSong.ArtistName;
                DurationSecondsTextBox.Text = _currentSong.DurationSeconds.ToString();
                GenreComboBox.SelectedItem = _currentSong.Genre;
            }
        }

        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedIndex == -1) return;

            try
            {
                string currentSongName = SongNameTextBox.Text;
                _currentSong.SongName = currentSongName;
                UpdateSongInfo();
                Serializer.Serialize(_songs);
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
            if (SongsListBox.SelectedIndex == -1) return;

            try
            {
                string currentArtistName = ArtistNameTextBox.Text;
                _currentSong.ArtistName = currentArtistName;
                UpdateSongInfo();
                Serializer.Serialize(_songs);
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
            if (SongsListBox.SelectedIndex == -1) return;

            try
            {
                string durationSecondsAsString = DurationSecondsTextBox.Text;
                double currentSongDurationSeconds = double.Parse(durationSecondsAsString);
                _currentSong.DurationSeconds = (int)currentSongDurationSeconds;
                Serializer.Serialize(_songs);
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
            if (SongsListBox.SelectedItem == null) return;

            _currentSong.Genre = (Genre)GenreComboBox.SelectedItem;
            Serializer.Serialize(_songs);
        }
    }
}
