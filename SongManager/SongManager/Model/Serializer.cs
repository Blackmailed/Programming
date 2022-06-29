using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json; 

namespace SongManager.Model
{
    public static class Serializer
    {

        private const string path1 = @"\Serialize.json";

        /// <summary>
        /// Путь до AppData
        /// </summary>

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        public static void Serialize(string path, List<Song> songs)
        {
            using (StreamWriter writer = new StreamWriter(path + path1))
            {
                writer.Write(JsonConvert.SerializeObject(songs));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию песен.</returns>
        public static List<Song> Deserialize(string path)
        {
            var songs = new List<Song>();

            try
            {
                using (StreamReader reader = new StreamReader(path + path1))
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
