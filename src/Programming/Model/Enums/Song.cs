using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Enums
{
    class Song
    {
        private int _duration;

        public Song()
        {
        }

        public Song(string author, string name, int duration)
        {
            Author = author;
            Name = name;
            Duration = duration;
        }
        public string Author { get; set; }
        
        public string Name { get; set; }

        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("the value of the Duration Seconds field must be greater than zero");
                }
                _duration = value;
            }
        }

    }
}
