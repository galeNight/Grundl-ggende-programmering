namespace OOPspotiflix
{
    internal class movie
    {
        public string? Title { get; set; }
        public DateTime Length { get; set; }
        public string? Genre { get; set; }
        public DateTime Relasedate { get; set; }
        public string? www { get; set; }
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
