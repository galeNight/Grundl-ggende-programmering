namespace OOP001
{
    public class program
    {
        static void Main(string[] args)
        {
            //type         referencannavn     instans(parentheses in constructor 
            MyFirstClass myFirsobject = new MyFirstClass();
            myFirsobject.str = "some text";
            myFirsobject.MyMethode();
            myFirsobject.age = 55;

            new MyFirstClass().MyMethode();

            person Myperson = new person();
            Myperson.name = "hugo";
            Myperson.age();
            Myperson.DoB = new DateTime();
        }
    }
}