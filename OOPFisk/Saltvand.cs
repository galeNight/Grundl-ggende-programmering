namespace OOPFisk
{
    internal class Saltvand : Fiskinfo
    {
        public List<Saltvandfarve>? farve { get; set; }
    }
    internal class Saltvandfarve : Fiskinfo
    {
        public string? hvilken { get; set; }
    }
}
