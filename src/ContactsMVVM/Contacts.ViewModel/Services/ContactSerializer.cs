using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.IO;

namespace Contacts.ViewModel.Services
{
    /// <summary>
    /// Сериализация и десериализация контактов <see cref="Contact"></see>
    /// </summary>
    /// <summary>
    /// Класс, описывающий методы для сериализации и десериализации.
    /// </summary>
    internal static class ContactSerializer
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private readonly static string _folderPath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "ContactsData");

        /// <summary>
        /// Путь к папке.
        /// </summary>
        private static readonly string _filePath = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "ContactsData", "contacts_data.json");


        /// <summary>
        /// Сохранение <see cref="ObservableCollection{ContactVM}"/>.
        /// </summary>
        /// <param name="contacts">Список контактов <see cref="ObservableCollection{ContactVM}"/></param>
        public static void SaveContacts(ObservableCollection<ContactVM> contacts)
        {
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_filePath));
            }
            string json = JsonConvert.SerializeObject(contacts);
            File.WriteAllText(_filePath, json);
        }

        /// <summary>
        /// Загрузка контактов <see cref="ObservableCollection{ContactVM}"/>.
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