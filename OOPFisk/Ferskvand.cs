namespace OOPFisk
{
    internal class Ferskvand : Fiskinfo
    {
        public List<Ferskvandfarve>? farve { get; set; }
    }
    internal class Ferskvandfarve : Fiskinfo
    {
        public string? hvilken { get; set; }
    }
}
