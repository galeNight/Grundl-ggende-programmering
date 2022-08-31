namespace Udregningsprogram
{
    class program
    { 
        static void Main(string[] arges)
        {
            while (true)
            {
                Menu();
            }
        }
        static void kasse()
        {
            double V, L, B, H;
            Console.WriteLine("Kasse");
            Console.WriteLine("indtast længde");
            L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast bredde");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast højde");
            H = Convert.ToDouble(Console.ReadLine());
            V = L * B * H;
            Console.WriteLine(V);
        }
        static void Prisme()
        {
            double G, H,V;
            Console.WriteLine("Prisme");
            Console.WriteLine("indtast grundflade");
            G= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast højde");
            H= Convert.ToDouble(Console.ReadLine());
            V= G * H;
            Console.WriteLine(V);
        }
        static void Cylindre()
        {
            double H,R,V;
            Console.WriteLine("cylindre");
            Console.WriteLine("indtast radius");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast højde");
            H = Convert.ToDouble(Console.ReadLine());
            V = Math.PI * (R * 2) * H;
            Console.WriteLine(V);
        }
        static void Kelge()
        {
            double G, H, V;
            Console.WriteLine("Kegle");
            Console.WriteLine("indtast grundflade");
            G = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast højde");
            H = Convert.ToDouble(Console.ReadLine());
            V = (1/3d) * G * H;
            Console.WriteLine(V);
        }
        static void Keglestub()
        {
            double G,H,R,V;
            Console.WriteLine("Kegle");
            Console.WriteLine("indtast grundflade");
            G = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast højde");
            H = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("indtast radius");
            R = Convert.ToDouble(Console.ReadLine());
            V = (1 / 3d) * H * Math.PI * (R * 2 + R * 2 + R * R);
            Console.WriteLine(V);
        }
        static void Kugle()
        {
            double R,V;
            Console.WriteLine("kugle");
            Console.WriteLine("indtast radius");
            R = Convert.ToDouble(Console.ReadLine());
            V = (4 / 3d) * (R * 3) * Math.PI;
            Console.WriteLine(V);
        }
        static void Menu()
        {
            Console.WriteLine("rumfanget af forskelige figur");
            Console.WriteLine("velg mellem 1-6 tal");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    kasse();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    Prisme();
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    Cylindre();
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                    Kelge();
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                    Keglestub();
                    break;
                case ConsoleKey.NumPad6:
                case ConsoleKey.D6:
                    Kugle();
                    break;
                default:
                    Console.WriteLine("forkert tast");
                    break;
            }
        }
    }
}