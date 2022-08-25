namespace OOP003
{
    internal class Person
    {
        public string name;
        public DateTime dob;
        private string email;
        public string password;
        public int Age { get { return Getage(); } }
        public int Getage()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (today < new DateTime(today.Year, dob.Month, dob.Day)) age--;
            return age;
        }

        public string Parsword
        {
            get {return password; }
            set
            {
                if (value.Length > 6 && value.Any(char.IsLower) && value.Any(char.IsDigit) && value.Any(char.IsUpper) && !value.Contains(" ")) ;
                else Console.WriteLine("password skal misv være 6 sam have store ,små og tal med i uden space");
                
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@") && value.Contains("."))
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("der skal være @ og . i din email");
                    email = null;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if(value==" ")
                {
                    Console.WriteLine("prøv igen");
                    name = null;
                }
                else name = value;
            }
        }
    }

}
