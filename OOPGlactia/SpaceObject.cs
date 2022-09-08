using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGlactia
{
    internal class SpaceObject
    {
        public string? Name { get; set; }
        public int Id { get; set; }
        public enum Startype { YellowDwarf, White, BlueNeutron, RedGiant }
        public enum Planettype { Terrestial, Giant, Dwarf, GasGiant,IceGigant }
        public Position? pos { get; set; }

        internal class Position
        {
            public Position(){}
            public Position(int x,int y)
            {
                //P1=position1
                //P2=position2
                X = x;
                Y = y;
            }
            public int x { get; }
            public int y { get; }
            public double X { get; set; }
            public double Y { get; set; }
            public override string ToString()
            {
                return $"{X},{Y}";
            }
        }
    }
}
