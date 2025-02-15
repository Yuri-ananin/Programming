using ContactsMVVM.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace ContactsMVVM.Model.Services
{
    /// <summary>
    /// Класс, предоставляющий методы для сериализации и десериализации списка контактов.
    /// </summary>
    internal static class ContactSerializer
    {
        /// <summary>
        /// Путь к папке, где хранятся данные.
        /// </summary>
        private readonly static string _folderPath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "ContactsMVVM");

        /// <summary>
        /// Полный путь к файлу JSON, содержащему список контактов.
        /// </summary>
        private static readonly string _filePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "ContactsMVVM", "contacts.json");


        /// <summary>
        /// Сохраняет коллекцию контактов в JSON-файл.
        /// </summary>
        /// <param name="contacts">Коллекция контактов <see cref="ObservableCollection{ContactVM}"/></param>
        public static void SaveContacts(ObservableCollection<ContactVM> contacts)
        {
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }
            string json = JsonConvert.SerializeObject(contacts);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Загружает список контактов из JSON-файла.
        /// </summary>
        /// <returns>Если найден файл, то вернёт список контактов <see cref="ObservableCollection{ContactVM}"/>, 
        /// иначе вернёт пустой список контактов <see cref="ObservableCollection{ContactVM}"/></returns>
        public static ObservableCollection<ContactVM> LoadContacts()
        {
            if (!File.Exists(_filePath))
            {
                return new ObservableCollection<ContactVM>();
            }
            string jsonData = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<ObservableCollection<ContactVM>>(jsonData);
        }
    }
}