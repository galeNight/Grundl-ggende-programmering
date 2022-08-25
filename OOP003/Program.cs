namespace OOP003
{
    class Program
    {
        static void Main(string[]ages)
        {
            Person myperson = new Person();
            Navn(myperson);
            Console.WriteLine("hey "+ myperson.name);
            Password(myperson);
            Console.WriteLine("password er "+ myperson.password);
            Age(myperson);
            Console.WriteLine(" din alder er "+ myperson.Age);
            Email(myperson);
            Console.WriteLine("din email er "+ myperson.Email);

        }
        static void Navn(Person myperson)
        {
            do
            {
                Console.WriteLine("Indtast navn");
                myperson.name = Console.ReadLine();
            }
            while (myperson.name==null);
        }
        static void Email(Person myperson)
        {
            do
            {
                Console.WriteLine("indtast email");
                myperson.Email = Console.ReadLine();
            }
            while(myperson.Email == null);
        }
        static void Password(Person myperson)
        {
            do
            {
                Console.WriteLine("indtast password");
                myperson.password = Console.ReadLine();
            }
            while(myperson.password == null);
        }
        static void Age(Person myperson)
        {
            myperson.dob=new DateTime(1995,12,26);
            Console.WriteLine($"alder {myperson.Age}");
        }
      
    }
}
