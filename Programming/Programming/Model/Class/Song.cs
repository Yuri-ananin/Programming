using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Song
    {
        private int _songTime;

        public string NameMusicGroup { get;set; }

        public string NameSong { get;set; }

        public int SongTime
        {
            get
            {
                return _songTime;
            }
            set
            {
                if(value > 0)
                {
                    _songTime = value;
                }
            }
        }

        public Song()
        {

        }

        public Song(int songTime, string nameMusicGroup, string nameSong)
        {
            SongTime = songTime;
            NameMusicGroup = nameMusicGroup;
            NameSong = nameSong;
        }
    }
}
