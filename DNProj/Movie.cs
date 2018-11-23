using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNProj
{
    class Movie
    { 
        public string Name { get; set; }
        public string Bio { get; set; }
        public int Time { get; set; }

        public Movie(string name, string bio, int time)
        {
            Name = name;
            Bio = bio;
            Time = time;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
