using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OOPGlactia.SpaceObject;

namespace OOPGlactia
{ 
    internal class Planet:SpaceObject
    {
        public Planettype Type { get; set; }
        public double Diameter { get; set; } // i M
        public double RotationPeriod { get; set; }// i timer
        public double RevolutionPeriod { get; set; } // i dage
        public List<Moon>? MoonList { get; set; } = new();
        public void Distance(Position F1,Position F2)
        {
           double distance= Math.Sqrt(Math.Pow((F2.X - F1.X), 2) + Math.Pow((F2.Y - F1.Y), 2));
        }
    }
}
