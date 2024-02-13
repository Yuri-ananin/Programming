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
        private static string FilepathStore = Path.Combine(GetFolderPath(SpecialFolder.ApplicationData), @"ObjectOrientedPracticsData\ObjectOrientedPracticsData.json");

        /// <summary>
        /// Метод для сохранения данных в json файл.
        /// </summary>
        /// <param name="store"> Список данных.</param>
        public static void SaveStore(Store store)
        {
            var jsonString = System.Text.Json.JsonSerializer.Serialize(store);
            if (!Directory.Exists(Path.Combine(Environment.GetFolderPath(
                        SpecialFolder.ApplicationData), @"ObjectOrientedPracticsData")))
            {
                Directory.CreateDirectory(Path.Combine(Environment.GetFolderPath(
                    SpecialFolder.ApplicationData), @"ObjectOrientedPracticsData"));
            }
            File.WriteAllText(FilepathStore, jsonString);
        }

        /// <summary>
        /// Метод для загрузки данных из json файла в список.
        /// </summary>
        /// <param name="store"> Список с данными</param>
        public static void StoreInfo(ref Store store)
        {
            if (File.Exists(FilepathStore))
            {
                store = JsonConvert.DeserializeObject<Store>(File.ReadAllText(FilepathStore));
            }
        }
    }
}
