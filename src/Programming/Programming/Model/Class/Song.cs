using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Class;
namespace Programming.Model
{
    /// <summary>
    /// Класс, описывающий песню.
    /// </summary>
    internal class Song
    {
        /// <summary>
        /// Продолжительность песни в минутах.
        /// </summary>
        private int _songTime;

        /// <summary>
        /// Возвращает и задает название музыкальной группы, исполняющей песню.
        /// </summary>
        public string NameMusicGroup { get;set; }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string NameSong { get;set; }

       /// <summary>
       /// Возвращает и задает продолжительность песни в минутах. Должна быть положительным числом.
       /// </summary>
        public int SongTime
        {
            get
            {
                return _songTime;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _songTime = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="songTime">Продолжительность песни в минутах. Должна быть положительным числом.</param>
        /// <param name="nameMusicGroup">Название музыкальной группы, которая исполняет песню.</param>
        /// <param name="nameSong">Название песни.</param>
        public Song(int songTime, string nameMusicGroup, string nameSong)
        {
            SongTime = songTime;
            NameMusicGroup = nameMusicGroup;
            NameSong = nameSong;
        }
    }
}
