namespace OOPspotiflix
{
    internal class Series
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public DateTime Lenght { get; set; }
        public DateTime Relasedate { get; set; }
        public string? WWW { get; set; }
        public List<Episode> Episodes { get; set; } = new();
        public string GetLenght()
        {
            return Lenght.ToString("hh:mm");
        }
        public string GetRelaseDate()
        {
            return Relasedate.ToString("D");
        }
    }
    internal class Episode
    {
        public string? EPTitle { get; set; }
        public DateTime Relasedate { get; set; }
        public int Season { get; set; }
        public int Episodenum { get; set; }
        public DateTime Lenght { get; set; }
        public string GetLenght()
        {
            return Lenght.ToString("hh:mm");
        }
        public string GetRelaseDate()
        {
            return Relasedate.ToString("D");
        }

    }

}
