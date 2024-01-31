using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Environment;

namespace SongsListApp.Model.Classes
{
    /// <summary>
    /// Класс, описывающий сохранение и загрузку json файла.
    /// </summary>
    internal class ProjectManager
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        readonly static string _filepath =
            (Path.Combine(Environment.GetFolderPath(SpecialFolder.ApplicationData), @"Songs\Songs.json"));

        /// <summary>
        /// Метод для загрузки данных из json файла в список
        /// </summary>
        public static List<Song> LoadSongs()
        {
            if (File.Exists(_filepath))
            {
                return JsonConvert.DeserializeObject<List<Song>>(File.ReadAllText(_filepath));
            }
            return new List<Song>();
        }

        /// <summary>
        /// Метод для сохранения данных в json файл.
        /// </summary>
        public static void SaveSongs(List<Song> _workersList)
        {
            if (_workersList.Count != 0)
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(_workersList);
                if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(
                    SpecialFolder.ApplicationData), @"Songs")))
                {
                    Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(
                        SpecialFolder.ApplicationData), @"Songs"));
                }

                File.WriteAllText(_filepath, jsonString);
            }
        }
    }
}
