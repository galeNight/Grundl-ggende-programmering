﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPspotiflix
{
    internal class Media
    {
        public string? Title { get; set; }
        public DateTime Length { get; set; }
        public string? Genre { get; set; }
        public DateTime ReleaseDate { get; set; } = DateTime.Today;
        public string? WWW { get; set; }

        public string GetReleaseDate()
        {
            return ReleaseDate.ToString("D");
        }
    }
}
