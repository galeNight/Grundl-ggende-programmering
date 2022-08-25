namespace OOP002
{
    internal class MyClass
    {
        private string str;
        public MyClass()
        {
            MyMethode();
        }
        public MyClass(string str)
        {
            this.str = str;
            MyMethode();
        }
        private void MyMethode()
        {
            Console.WriteLine("this is our string" + str);
            Console.WriteLine();
        }
    }
}
