using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using static System.Environment;

namespace SongManager.Model
{
    /// <summary>
    /// Реализация сериализации и десериализации данных.
    /// </summary>
    public static class Serializer
    {
        /// <summary>
        /// Возвращает и задает путь куда будут сериализоваться данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public static string FileName { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Serializer"/>.
        /// </summary>
        static Serializer()
        {
            Path = $@"{GetFolderPath(SpecialFolder.ApplicationData)}" + "/SongManager/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="songs">Коллекция класса <see cref="Song"/></param>
        public static void Serialize(List<Song> songs)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(songs));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию песен.</returns>
        public static List<Song> Deserialize()
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            var songs = new List<Song>();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    songs = JsonConvert.DeserializeObject<List<Song>>(reader.ReadToEnd());
                }

                if (songs == null)
                {
                    songs = new List<Song>();
                }
            }
            catch
            {
                return songs;
            }

            return songs;
        }
    }
}
