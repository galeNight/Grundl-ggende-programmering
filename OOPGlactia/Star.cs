using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGlactia
{
    internal class Star:SpaceObject
    {
        public string? Type { get; set; }
        public int Temperature { get; set; }
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public List<Planet>? Planetlist { get; set; } = new();
        new Position? position { get; }
        public Star()
        {
            this.position = new Position(0,0);
        }
    }
}
