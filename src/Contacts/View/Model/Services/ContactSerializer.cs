using View.Model;
using Newtonsoft.Json;
using System;
using System.IO;

namespace View.Model.Services
{
    /// <summary>
    /// Класс, описывающий методы для сериализации.
    /// </summary>
    public static class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        private static readonly string _filePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "Contacts", "contacts.json");

        /// <summary>
        /// Метод для сохранения данных в json.
        /// </summary>
        /// <param name="contact">Данные о контакте.</param>
        public static void SaveContact(Contact contact)
        {
            string json = JsonConvert.SerializeObject(contact);
            Directory.CreateDirectory(Path.GetDirectoryName(_filePath));
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Метод для загрузки данных из json.
        /// </summary>
        /// <returns><see cref="Contact"></returns>
        public static Contact LoadContact()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                return JsonConvert.DeserializeObject<Contact>(json);
            }

            return null;
        }
    }
}