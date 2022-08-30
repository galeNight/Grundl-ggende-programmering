using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPspotiflix
{
    internal class Series : Media
    {
        public List<Episode> Episodes { get; set; } = new();
    }
    internal class Episode : Media
    {
        public int Season { get; set; }
        public int EpisodeNum { get; set; }
        public string GetLength()
        {
            return Length.ToString("mm");
        }

    }
}
