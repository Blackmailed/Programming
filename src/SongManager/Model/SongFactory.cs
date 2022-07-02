using System.Collections.Generic;
using System.Linq;

namespace SongManager.Model
{
    /// <summary>
    /// Предоставляет методы для работы с данными песен.
    /// </summary>
    public static class SongFactory
    {
        /// <summary>
        /// Создание дефолтных значений для песни.
        /// </summary>
        /// <returns>Дефолтные значения о песне.</returns>
        public static Song DefaultInfo()
        {
            Song song = new Song();
            song.SongName = "Название песни";
            song.ArtistName = "Имя исполнителя";
            song.DurationSeconds = 1;
            song.Genre = Genre.None;
            return song;
        }

        /// <summary>
        /// Проводит сортировку коллекции песен по имени исполнителя и названию песни.
        /// </summary>
        /// <param name="Songs">Коллекция класса <see cref="Song"/>.</param>
        /// <returns>Возвращает отсортированную коллекцию песен.</returns>
        public static List<Song> SortSongs(List<Song> songs)
        {
            var sortedSongList = from song in songs
                                 orderby song.ArtistName, song.SongName
                                 select song;

            return sortedSongList.ToList();
        }
    }
}
