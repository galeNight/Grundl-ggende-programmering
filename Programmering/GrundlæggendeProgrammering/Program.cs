namespace GrundlæggendeProgrammering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indtast 1 ,2 eller 3");
            string indput = Console.ReadLine();
            if (indput == "1")
            {
                celsius();
            }
            else if (indput == "2")
            {
                temperrarure();
            }
            else if(indput == "3")
            {
                valutaomregner();
            }
            else
            {
                Console.WriteLine("forkert tats");
            }

        }
        static void celsius()
        {
            //opgave 1.1 fra fahrenheit til celsius
            double fahrenheit, celsius;
            Console.WriteLine("indtast decimal tal");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine(celsius);
        }
        // opgave 1.2 fra celsius til fahrenheit,kelvin og réaumor
        static void temperrarure()
        {
            double fahrenheit, celsius, kelvin, réaumur;
            Console.WriteLine("indtast decimal tal");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 9 / 5) + 32;
            kelvin = celsius + 273.15;
            réaumur = celsius * 0.8;

            Console.WriteLine("temparatur fra celsius til fahrenheit " + fahrenheit);
            Console.WriteLine("temparatur fra celsius til Kelvin " + kelvin);
            Console.WriteLine("temparatur fra celsius til Réaumur " + réaumur);
        }        
        static void valutaomregner()
        {
            double Euro, dk, kurs=7.51;
            Console.WriteLine("indtast antal euro");
            Euro = Convert.ToDouble(Console.ReadLine());
            dk = Euro * kurs;
            Console.WriteLine($"du har væklset antal {Euro} euro til antal {dk} kr ");
        }
    }
}