using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arbejdsopgave
{
    internal class skole
    {
        public string? navn { get; set; }
        public int vægt { get; set; }
        public int conditions { get; set; }
    }
    internal class skoletaske: skole
    {
        public penalhus? penalhus { get; set; }
        public List<bøger>? bøgliste { get; set; }
        public madkasse? mad { get; set; }
    }
    internal class bøger: skole
    {
        public string? forfatter { get; set; }
    }
    internal class penalhus : skole
    {
        public List<blyanter>?  blyanterliste { get; set; }
        public List<viskelæder>? viskelæderliste { get; set; }
    }
    internal class viskelæder : skole
    {
        public string? lugt { get; set; }
    }
    internal class blyanter : skole
    {
        public string? farve { get; set; }
    }
    internal class madkasse : skole
    {
        public List<mad>? madliste { get; set; }=new();
    }
    internal class mad : skole
    {
        public string? smag { get; set; }
    }
}
