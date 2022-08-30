using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPspotiflix
{
    internal class Music
    {
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? Genre { get; set; }
        public string? Album { get; set; }
        public string? WWWW { get; set; }
        public DateTime Length { get; set; }
        public DateTime Relasedate { get; set; }

        public string GetLenght()
        {
            return Length.ToString("hh:mm");
        }
        public string GetRelaseDate()
        {
            return Relasedate.ToString("D");
        }
    }
}
