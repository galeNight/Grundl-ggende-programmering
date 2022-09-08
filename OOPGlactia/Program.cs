using System;
using static OOPGlactia.SpaceObject;

namespace OOPGlactia
{
    class program
    {
        static void Main(string[] args)
        {
            Star sun = new Star()
            {
                Id = 1,
                Name = "sun",
                Type= Startype.YellowDwarf.ToString(),
                Temperature= 5778
            };
            Planet Mercury = new Planet() 
            {
                Id=1,
                Name= "Mercury",
                pos=(new SpaceObject.Position() { X=0,Y=0}),
                Type=Planettype.Terrestial,
                Diameter= 4879,
                RotationPeriod=3,
                RevolutionPeriod= 87969,
            };
            Planet Venus = new Planet()
            {
                Id=2,
                Name="Venus",
                pos=(new SpaceObject.Position() {X=0,Y=0}),
                Type=Planettype.Terrestial,
                Diameter=12104,
                RotationPeriod=24,
                RevolutionPeriod=224
            };
            Planet Earth = new Planet()
            {
                Id = 3,
                Name = "Earth",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.Terrestial,
                Diameter = 12742,
                RotationPeriod = 23.9,
                RevolutionPeriod = 365
            };
            Planet Mars = new Planet()
            {
                Id = 4,
                Name = "Mars",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.Terrestial,
                Diameter = 6.779,
                RotationPeriod = 24.6,
                RevolutionPeriod = 687
            };
            Planet Jupiter = new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.GasGiant,
                Diameter = 139.820,
                RotationPeriod = 9.925,
                RevolutionPeriod = 4.380
            };
            Planet Saturn = new Planet()
            {
                Id = 6,
                Name = "Saturn",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.GasGiant,
                Diameter = 116.460,
                RotationPeriod = 10,
                RevolutionPeriod = 10.585
            };
            Planet Uranus = new Planet()
            {
                Id = 7,
                Name = "Uranus",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.GasGiant,
                Diameter = 50.724,
                RotationPeriod = 17,
                RevolutionPeriod = 30.660
            };
            Planet Neptune = new Planet()
            {
                Id = 8,
                Name = "Neptune",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.IceGigant,
                Diameter = 49.244,
                RotationPeriod = 16,
                RevolutionPeriod = 43.725
            };
            Moon Luna = new Moon()
            {
                Id=1,
                Name = "Luna",
                pos=(new SpaceObject.Position() { X=0,Y=0}),
                Diameter=3.474,
                RotationPeriod= 27,
                RevolutionPeriod= 27
            };
            Moon Titan = new Moon()
            {
                Id = 2,
                Name = "Titan",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Diameter = 5.149,
                RotationPeriod = 15,
                RevolutionPeriod = 16
            };
            Moon Phobos = new Moon()
            {
                Id = 3,
                Name = "Phobos",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Diameter = 22.533,
                RotationPeriod = 7,
                RevolutionPeriod = 8
            };
            Moon Europe = new Moon()
            {
                Id = 4,
                Name = "Europe",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.Terrestial,
                Diameter = 3.121,
                RotationPeriod = 3,
                RevolutionPeriod = 85
            }; 
            Moon Deimos = new Moon()
            {
                Id = 5,
                Name = "Deimos",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Diameter = 123,
                RotationPeriod = 123,
                RevolutionPeriod = 123
            }; 
            Moon Ganymedes = new Moon()
            {
                Id = 6,
                Name = "Ganymedes",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.Terrestial,
                Diameter = 5.268,
                RotationPeriod = 7,
                RevolutionPeriod = 172
            }; 
            Moon Io = new Moon()
            {
                Id = 7,
                Name = "Io",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Diameter = 3.643,
                RotationPeriod = 17,
                RevolutionPeriod = 1.7
            }; 
            Moon Mimas = new Moon()
            {
                Id = 8,
                Name = "Mimas",
                pos = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = Planettype.Terrestial,
                Diameter = 396.4,
                RotationPeriod = 22,
                RevolutionPeriod = 0.9
            };

            sun.Planetlist.Add(Mercury);
            sun.Planetlist.Add(Venus);
            sun.Planetlist.Add(Earth);
            sun.Planetlist.Add(Mars);
            sun.Planetlist.Add(Jupiter);
            sun.Planetlist.Add(Saturn);
            sun.Planetlist.Add(Uranus);
            sun.Planetlist.Add(Neptune);

            Mars.MoonList.Add(Deimos);
            Mars.MoonList.Add(Phobos);
            Earth.MoonList.Add(Luna);
            Jupiter.MoonList.Add(Europe);
            Jupiter.MoonList.Add(Ganymedes);
            Jupiter.MoonList.Add(Io);
            Saturn.MoonList.Add(Titan);

            foreach (Planet p in sun.Planetlist)
            {
                Console.WriteLine($"id: {p.Id}\nname: {p.Name}\nposition: {p.pos}\n" +
                    $"type: {p.Type}\ndiameter: {p.Diameter}nRotationPeriod: " +
                    $"{p.RotationPeriod}\nRevolutionPeriod: {p.RotationPeriod} ");
                if (p.MoonList != null && p.MoonList.Count != 0)
                {
                    foreach (Moon m in p.MoonList)
                    {
                        Console.WriteLine($"id: {m.Id}\nname: {m.Name}\nposition: {m.pos}\n" +
                            $"Diameter: {m.Diameter}\nRotationPeriod: {m.RotationPeriod}\n" +
                            $"RevolutionPeriod: {m.RevolutionPeriod}");
                    }
                }
            }
        }
    }
}
