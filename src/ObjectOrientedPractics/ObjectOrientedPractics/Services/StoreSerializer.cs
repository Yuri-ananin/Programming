using Newtonsoft.Json;
using ObjectOrientedPractics.Model;
using static System.Environment;

namespace ObjectOrientedPractics.Services
{
    internal class StoreSerializer
    {
        /// <summary>
        /// Путь к файлу
        /// </summary>
        readonly static string FilepathStore = Path.Combine(GetFolderPath(SpecialFolder.ApplicationData), @"Test4\Test4.json");

        /// <summary>
        /// Метод для сохранения данных в json файл.
        /// </summary>
        /// <param name="store"> Список данных.</param>
        public static void SaveStore(Store store)
        {
            try
            {
                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    TypeNameHandling = TypeNameHandling.All  // Добавляет информацию о типе
                };

                var jsonString = JsonConvert.SerializeObject(store, settings);

                if (string.IsNullOrWhiteSpace(jsonString))
                {
                    throw new Exception("Сериализация вернула пустую строку.");
                }

                var directory = Path.Combine(GetFolderPath(SpecialFolder.ApplicationData), @"Test4");
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                File.WriteAllText(FilepathStore, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при сохранении: {ex.Message}");
            }
        }

        /// <summary>
        /// Метод для загрузки данных из json файла в список.
        /// </summary>
        /// <param name="store"> Список с данными</param>
        public static void StoreInfo(ref Store store)
        {
            try
            {
                if (File.Exists(FilepathStore))
                {
                    var settings = new JsonSerializerSettings
                    {
                        TypeNameHandling = TypeNameHandling.All  // Десериализация с использованием информации о типе
                    };

                    var jsonString = File.ReadAllText(FilepathStore);
                    store = JsonConvert.DeserializeObject<Store>(jsonString, settings);
                }
                else
                {
                    Console.WriteLine("Файл с данными не найден.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке: {ex.Message}");
            }
        }
    }
}
