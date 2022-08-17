namespace GpArray
{
    class program
    {
        //the arrat for the detale of the argument int text
        static string[] arrangements = new string[100];
        static int[,] tickets = new int[1000, 2];
        static void Main(string[] args)
        {
            addtoarray();
            while (true)
            {
               Menu();
            }
            
        }
        static void Menu()
        {
            Console.WriteLine("\n1. vis arrangementer\n2. køb Billet\n3. vis alle billeter\n\n indtast valg");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.D1:
                    showallargements();
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                    showallargements();
                    int t=buytecket();
                    Console.WriteLine("billet nummer:" + t);
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                    showticketbought();
                    break;
                default:
                    break;
            }
        }
        static int buytecket()
        {
            Console.Write("indtast nr på argument du ønsker at købe billet");
            string indput = Console.ReadLine();
            int.TryParse(indput,out int arrangementsNumber);
            Console.Write("intast antalønsked billeter");
            indput = Console.ReadLine();
            int.TryParse(indput, out int amountoftickets);

            int freesport=Getnextfreespotinticketarray();
            tickets[freesport, 0] = amountoftickets;
            tickets[freesport, 1] = arrangementsNumber;
            return freesport;
        }
        static void showticketbought()
        {
            Console.WriteLine("antal\tarrangement\tlokation");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i, 0] == 0) return;
                string arr = arrangements[tickets[i, 1]];
                string[] splitarray = arr.Split("-");
                Console.WriteLine(tickets[i, 0] + "\t" + splitarray[0] + "\t" + splitarray[1]);

            }
        }
        static int Getnextfreespotinticketarray()
        {
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i, 0] == 0) { return i; }
            }
            return 0;
        }
        static void showallargements()
        {
            foreach (string arr in arrangements)
            {
                showarragements(arr);
            }
        }
        static void showarragements(string arr)
        {
            if (arr != null && arr != "")
            {
                
                if (arr != null && arr != "")
                {
                    int i = Array.IndexOf(arrangements, arr);
                    Console.WriteLine(i + "" + arr);
                }
                
            }
        }
        static void addtoarray()
        {
            arrangements[0] = "Lil Johan";
            arrangements[1] = "Deagle";
            arrangements[2] = "Tec læreband - amager plads";

        }
    }
} 