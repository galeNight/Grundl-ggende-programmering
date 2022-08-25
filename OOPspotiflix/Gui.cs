using System.Text.Json;
namespace OOPspotiflix
{
    internal class Gui
    {
        //public List<movie> movielist = new();
        data data = new data();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Gui()
        {
            data.movielist = new();
            data.movielist.Add(new movie() {www=@"https:\\netflix.com/rambo3.mp4", 
            Title = "Rambo III", Genre = "Action", Relasedate = new DateTime(1988, 5,25), Length = new DateTime(01, 01, 0001, 1, 42, 00) });
            while (true)
            {
                Menu();
            }
        }
        private void Menu()
        {
            Console.WriteLine("1 for movies\n2 for serise\n3 for music\n4 for save\n5 for load");

            switch (Console.ReadKey(true).Key)
            {
               
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    MovieMenu();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    savedata();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:

                    break;
            }
        }
        private void MovieMenu()
        {
            Console.WriteLine("\n Movie Menu \n1 for list\n2 for search movie\n3 for add new movie");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ShowMovieList();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Searchmovie();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AddMovie();
                    break;
            }
        }
        private void savedata()
        {
            string Json = JsonSerializer.Serialize(data);
            File.WriteAllText(path + @"/spotiflixdata.Json" ,Json);
            Console.WriteLine("file saved succesfully at "+ path);
        }
        private void LoadData()
        {
            string  json=File.ReadAllText(path+ @"/spotiflixdata.Json.Json");
           data = System.Text.Json.JsonSerializer.Deserialize<data>(json);
            Console.WriteLine("file loaded succesfully at "+ path);
        }
        private void ShowMovie(movie m)
        {
            Console.WriteLine($"{m.Title} {m.GetLenght()}{m.Genre}{m.GetRelaseDate}{m.www}");
        }
        private void ShowMovieList()
        {
            foreach(movie m in data.movielist)
            {
                ShowMovie(m);
            }
        }
        private void AddMovie()
        {
            movie Movie = new movie();
            Movie.Title = Addstring("Title: ");
            Movie.Length=GetLenght();
            Movie.Genre = Addstring("Grenre: ");
            Movie.Relasedate = GetRelease();
            Movie.www = Addstring("WWW: ");

            ShowMovie(Movie);
            Console.WriteLine("Confirm adding to list (Y/N)");
            switch (Console.ReadKey(true).Key)
            {

                case ConsoleKey.Y:
                    data.movielist.Add(Movie);
                    break;
                default:
                    break;
            }
        }
        private void Searchmovie()
        {
            Console.WriteLine("Search: ");
            string? search = Console.ReadLine();
            foreach(movie movie in data.movielist)
            {
                if (search !=null)
                {
                    if(movie.Title!=search|| movie.Genre.Contains(search))
                    ShowMovie(movie);
                }
            }
        }
        private DateTime GetLenght()
        {            
            DateTime to = new();
            do
            {
                Console.WriteLine("Lenght (hh:mm:ss");
            }
            while (!DateTime.TryParse("01-01-0001" + Console.ReadLine(), out to));
            return to;
        }
        private DateTime GetRelease()
        {
            DateTime dateOnly;
            do
            {
                Console.WriteLine("Relase Date (dd/mm/yyyy)");
            }
            while (!DateTime.TryParse(Console.ReadLine(), out dateOnly));
            return dateOnly;
        }
        private string Addstring(string type)
        {
            string? indput;
            do
            {
                Console.WriteLine(type);
                indput = Console.ReadLine();
            }
            while (indput == null || indput == "");
            return indput;
        }


    }
}
