using System.Text.Json;

namespace OOPFisk
{
    internal class Gui
    {
        Data data=new Data();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Gui()
        {
            data.ferskvandlist = new();
            data.Saltvandslist = new();
            while (true)
            {
                Menu();
            }
        }
        #region data
        private void Menu()
        {

            Console.WriteLine("1 for Ferskvand\n2 for Saltvand\n3 for savedata\n4 for loaddata");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Ferskvandmenu();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    saltvandmenu();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Savedata();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad5:
                    Loaddata();
                    break;
                default:
                    break;
            }
        }
        private void Savedata()
        {
            string Json =System.Text.Json.JsonSerializer.Serialize(data);
            File.WriteAllText(path, Json);
            Console.WriteLine("file saved succesfully at " + path);
        }
        private void Loaddata()
        {
            string json = File.ReadAllText(path);
            data = System.Text.Json.JsonSerializer.Deserialize<Data>(json);
            Console.WriteLine("file loaded succesfully at " + path);
        }
        #endregion
        #region indput
        private string Getstring(string type)
        {
            string? indput;
            do
            {
                Console.WriteLine(type);
                indput = Console.ReadLine();
            }
            while(indput == null||indput=="");
            return indput;
        }
        private int Getint(string request)
        {
            int i;
            do
            {
                Console.WriteLine(request);
            }
            while(!int.TryParse(Console.ReadLine(),out i));
            return i;
        }
        #endregion
        #region ferskvand
        private void Ferskvandmenu()
        {
            Console.WriteLine("\nFerskvandmenu\n1 for list\n2 for search\n3 for add fisk");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.Clear();
                    Showferskvandlist();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.Clear();
                    Searchferskvandfisk();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.Clear();
                    Addferskvandfisk();
                    break;
                default:
                    break;
            }
        }
        private void Showferskvandfisk(Ferskvand f)
        {
            Console.WriteLine($"{f.Navn}{f.Længte}{f.Vægt}{f.Food}");
            foreach (Ferskvandfarve c in f.farve)
            {
                Console.WriteLine($" {c.hvilken}");

            }
        }
        private void Showferskvandlist()
        {
            foreach(Ferskvand f in data.ferskvandlist)
            {
                Showferskvandfisk(f);
            }
        }
        private void Addferskvandfisk()
        {
            Ferskvand ferskvand = new Ferskvand();
            ferskvand.Navn = Getstring("Navn: ");
            ferskvand.Food = Getstring("Canivor/Hebivor: ");
            ferskvand.Længte = Getint("Længte:");
            ferskvand.Vægt = Getint("Vægt: ");
            Console.Clear();
            Showferskvandfisk(ferskvand);
            Console.WriteLine("konfomation på at tilføje til listen (Y/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) data.ferskvandlist.Add(ferskvand);
            do
            {
                Addferskvandfarve(ferskvand);
                Console.WriteLine("tilføj en anden farve (Y/N)");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
                
            
        }
        private void Searchferskvandfisk()
        {
            Console.WriteLine("Search:");
            string? search = Console.ReadLine();
            foreach (Ferskvand ferskvand in data.ferskvandlist)
            {
                if (search != null)
                {
                    if (ferskvand.Navn!=search||ferskvand.Food.Contains(search))
                        Showferskvandfisk(ferskvand);
                }
            }
        }
        private void Addferskvandfarve(Ferskvand ferskvand)
        {
            Ferskvandfarve farve = new Ferskvandfarve();
            farve.hvilken = Getstring("Fisk farve: ");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) ferskvand.farve.Add(farve);

        }
        #endregion
        #region saltvand
        private void saltvandmenu()
        {
            Console.WriteLine("\nSaltvandmenu\n1 for list\n2 for search\n3 for add fisk");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Showsaltvadfisklist();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Addsaltvandfisk();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Searchsaltvandfisk();
                    break;
                default:
                    break;
            }
        }
        private void Showsaltvandfisk(Saltvand s)
        {
            Console.WriteLine($"{s.Navn} {s.Længte}{s.Vægt}{s.Food}");
            foreach (Saltvandfarve c in s.farve)
            {
                Console.WriteLine($" {c.hvilken}");
            }
        }
        private void Showsaltvadfisklist()
        {
            foreach(Saltvand s in data.Saltvandslist)
            {
                Showsaltvandfisk(s);
            }
        }
        private void Addsaltvandfisk()
        {
            Saltvand saltvand = new Saltvand();
            saltvand.Navn = Getstring("Navn: ");
            saltvand.Food = Getstring("Carnivor/hebivor: ");
            saltvand.Længte = Getint("Længte: ");
            saltvand.Vægt = Getint("vægte: ");

            Showsaltvandfisk(saltvand);
            Console.WriteLine("konfomation på at tilføje til listen (Y/N)");
            if(Console.ReadKey(true).Key==ConsoleKey.Y)data.Saltvandslist.Add(saltvand);
            do
            {
                Addsaltvandfarve(saltvand);
                Console.WriteLine("tilføj en anden farve(Y/N)");
            }
            while (Console.ReadKey(true).Key == ConsoleKey.Y);
        }
        private void Searchsaltvandfisk()
        {
            Console.WriteLine("Search: ");
            string? search = Console.ReadLine();
            foreach(Saltvand saltvand in data.Saltvandslist)
            {
                if (search != null)
                {
                    if (saltvand.Navn != search || saltvand.Food.Contains(search))
                        Showsaltvandfisk(saltvand);
                }
            }
        }
        private void Addsaltvandfarve(Saltvand saltvand)
        {
            Saltvandfarve farve = new Saltvandfarve();
            farve.hvilken = Getstring("fisk farve: ");
            if (Console.ReadKey(true).Key == ConsoleKey.Y) saltvand.farve.Add(farve);
        }
        #endregion
    }
}
