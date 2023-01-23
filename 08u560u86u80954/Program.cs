class Program
{
    static void Main(string[] args)
    {
        string brugernavn, password;
        int forsøg = 0;
        do
        {
            Console.WriteLine("indtast brugernavn");
            brugernavn = Console.ReadLine();
        }
        while (brugernavn != "tec123");

        if (brugernavn == "tec123" || brugernavn == "Tec123")
        {
            do
            {
                Console.WriteLine("indtast password");
                password = Console.ReadLine();
                forsøg++;
            }
            while (password != "tec321" && forsøg != 5);

                if (password == "tec321" || password == "Tec321")
                {
                    Console.WriteLine("velkommen til systemet");
                }
        }
        else
        {
            Console.WriteLine("der blev tastet forkert. Du har ikke adgang til systemet");
        }
        Console.ReadKey();
    }
}