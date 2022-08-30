using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPspotiflix
{
    internal class Album : Media
    {
        public List<Song> Songs { get; set; } = new();
        public string? Artist { get; set; }
        public string GetLength()
        {
            return Length.ToString("hh:mm");
        }
    }
    internal class Song : Media
    {
        public string? Artist { get; set; }
        public string GetLength()
        {
            return Length.ToString("mm:ss");
        }
    }
}
