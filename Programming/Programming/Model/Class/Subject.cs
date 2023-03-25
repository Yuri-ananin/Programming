using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Subject
    {
        private int _learnTime;

        private int _mark;

        public string Name { get; set; }

        public int LearnTime
        {
            get
            {
                return _learnTime;
            }
            set
            {
                if(value > 0)
                {
                    _learnTime = value;
                }
            }
        }

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if(value > 1 && value < 6)
                {
                    _mark = value;
                }
            }
        }

        public Subject()
        {

        }

        public Subject(int learnTime, int mark, string name)
        {
            Name = name;
            LearnTime = learnTime;
            Mark = mark;
        }
    }
}
