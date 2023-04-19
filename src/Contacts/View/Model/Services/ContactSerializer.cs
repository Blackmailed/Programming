using Newtonsoft.Json;
using System.IO;

namespace View.Model.Services
{
    public static class ContactSerializer
    {
        /// <summary>
        /// Сериализация данных.
        /// </summary>
        /// <param name="contact">Контакт.</param>
        /// <param name="path">Путь куда происходит сериализация данных.</param>
        public static void Serialize(Contact contact, string path)
        {
            if (!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(JsonConvert.SerializeObject(contact));
            }
        }

        /// <summary>
        /// Десериализация данных.
        /// </summary>
        /// <param name="path">Путь.</param>
        /// <returns>Возвращает экземпляр класса <see cref="Contact"/>.</returns>
        public static Contact Deserialize(string path)
        {
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            var contact = new Contact();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    contact = JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd());
                }

                if (contact == null) contact = new Contact();
            }
            catch (FileNotFoundException e)
            {
                return contact;
            }

            return contact;
        }
    }
}
