using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Model.Services
{
    /// <summary>
    /// Представляет реализацию сериалайзера. 
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь сохранения файла (Мои документы).
        /// </summary>
        public static string Path { get; set; }
            = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="contacts">Коллекция контактов.</param>
        /// <param name="path">Путь сериализации.</param>
        public static void Serialize(ObservableCollection<Contact> contacts)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }

            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contacts));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <param name="path">Путь десериализации.</param>
        /// <returns>Список контактов.</returns>
        public static ObservableCollection<Contact> Deserialize()
        {
            ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contacts = JsonConvert.DeserializeObject
                    <ObservableCollection<Contact>>(sr.ReadToEnd());
                }
            }
            else
            {
                File.Create(Path).Close();
            }

            return contacts;
        }
    }
}
