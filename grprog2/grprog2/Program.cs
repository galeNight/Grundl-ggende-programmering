using System;

namespace grprog2
{
    class program
    {
        static void Main(string[] args)
        {
            do
            {
                double[] talindput = indput();
                double[] resultat = calculate(talindput);
                udskriv(talindput, resultat);
                Console.WriteLine("prøv igen (y/n)");
            }
            while (Console.ReadKey().Key==ConsoleKey.Y);
            static double[] indput()
            {
                double tal1, tal2; ;
                Console.WriteLine("indtast tal");
                tal1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("indtast tal");
                tal2 = Convert.ToDouble(Console.ReadLine());
                double[] talindput = { tal1, tal2 };
                return talindput;
            }
            static double[] calculate(double[] talindput)
            {
                double resultat1 = talindput[0] * talindput[1] / 100d;
                double resultat2 = talindput[1] * talindput[0] / 100;
                double[] resultat = { resultat1, resultat2 };
                return resultat;
            }
            static void udskriv(double[] resultat, double[]talindput)
            {
                Console.WriteLine($"{talindput[0]} % af {talindput[1]} er {resultat[0]}");
                Console.WriteLine($"{talindput[1]} % af {talindput[0]} er {resultat[1]}");
            }
        }
    }
}