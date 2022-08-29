using System.Text.Json;
using static OOPspotiflix.movie;

namespace OOPspotiflix
{
    internal class Gui
    {
        data data = new data();
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Gui()
        {
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
                    SeriesMenu();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    MusicMenu();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    savedata();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    LoadData();
                    break;
                default:
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
                default:
                    break;
            }
        }
        private void ShowMovie( movie m)
        {
            Console.Write("Search: ");
            string? search = Console.ReadLine();
            foreach (movie movie in data.movielist)
            {
                if (search != null)
                {
                    if (movie.Title.Contains(search) || movie.Genre.Contains(search))
                        ShowMovie(movie);
                }
            }
        }
        private void ShowMovieList()
        {
            foreach (movie m in data.movielist)
            {
                ShowMovie(m);
            }
        }
        private void AddMovie()
        {
            movie Movie = new movie();
            Movie.Title = Getstring("Title: ");
            Movie.Length = GetLenght();
            Movie.Genre = Getstring("Grenre: ");
            Movie.ReleaseDate = GetRelease();
            Movie.WWW = Getstring("WWW: ");

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
            foreach (movie movie in data.movielist)
            {
                if (search != null)
                {
                    if (movie.Title != search || movie.Genre.Contains(search))
                        ShowMovie(movie);
                }
            }
        }


        private void SeriesMenu()
        {
            Console.WriteLine("\n Series Menu \n1 for Serieslist\n2 for search Series\n3 for add new Series");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ShowSeriesList();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    SearchSeries();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AddSeries();
                    break;
                default:
                    break;
            }
        }
        private void AddSeries()
        {
            Series series = new Series();
            series.Title = Getstring("Title: ");
            series.Genre = Getstring("Genre: ");
            series.WWW = Getstring("WWW: ");
            //series.Lenght = GetLenght();
            series.ReleaseDate = GetRelease();

            Console.WriteLine("add Series (Y/N)");
            if(Console.ReadKey().Key== ConsoleKey.Y)data.serieslist.Add(series);

            Console.WriteLine("add episode?");
            if (Console.ReadKey().Key == ConsoleKey.Y) AddEpisode(series);

        }
        private void AddEpisode(Series series)
        {
            do
            {
                Episode episode = new Episode();
                episode.Title = Getstring("Title: ");
                episode.Season = GetInt("Season: ");
                episode.EpisodeNum = GetInt("Episode number: ");
                episode.Length = GetLenght();
                episode.ReleaseDate = GetRelease();

                Console.WriteLine("add episode(Y/N)");
                if (Console.ReadKey().Key == ConsoleKey.Y) series.Episodes.Add(episode);
                Console.WriteLine("add another episode");
            }
            while (Console.ReadKey().Key==ConsoleKey.Y);


        }
        private void ShowSeries(Series s)
        {
            Console.WriteLine($"{s.Title}{s.Genre}{s.GetReleaseDate}{s.WWW}");
        }
        private void ShowSeriesList()
        {
            foreach(Series s in data.serieslist)
            {
                ShowSeries(s);
            }
        }
        private void SearchSeries()
        {
            Console.WriteLine("search: ");
            string? search = Console.ReadLine();
            foreach(Series series in data.serieslist)
            {
                if(search != null)
                {
                    if(series.Title != search||series.Genre.Contains(search))
                        ShowSeries(series);
                }
            }
        }


        private void MusicMenu()
        {
            Console.WriteLine("\n Music Menu \n1 for Musiclist\n2 for search Music\n3 for add new Music");
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    ShowMusicList();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    SearchMusic();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    AddMusic();
                    break;
                default:
                    break;
            }
        }
        private void AddMusic()
        {
            Music music=new Music();
            music.Title = Getstring("Title: ");
            music.Artist = Getstring("Artist: ");
            music.Genre = Getstring("Genre: ");
            music.Album = Getstring("Album: ");
            music.WWWW = Getstring("WWW: ");
            music.Length = GetLenght();
            music.Relasedate = GetRelease();

            ShowMusic(music);
            Console.WriteLine("Confirm adding to list (Y/N)");
            switch (Console.ReadKey(true).Key)
            {

                case ConsoleKey.Y:
                    data.musiclist.Add(music);
                    break;
                default:
                    break;
            }
        }
        private void ShowMusic(Music mc)
        {
            Console.WriteLine($"{mc.Title}{mc.Artist}{mc.Genre}{mc.Album}{mc.GetLenght}{mc.GetRelaseDate}{mc.WWWW}");
        }
        private void ShowMusicList()
        {
            foreach(Music mc in data.musiclist)
            {
                ShowMusic(mc);
            }
        }
        private void SearchMusic()
        {
            Console.WriteLine("Search: ");
            string? search = Console.ReadLine();
            foreach(Music music in data.musiclist)
            {
                if (search != null)
                {
                    if (music.Title != search || music.Genre.Contains(search))
                        ShowMusic(music);
                }
            }
        }


        private void savedata()
        {
            string Json = JsonSerializer.Serialize(data);
            File.WriteAllText(path, Json);
            Console.WriteLine("file saved succesfully at " + path);
        }
        private void LoadData()
        {
            string json = File.ReadAllText(path);
            data = System.Text.Json.JsonSerializer.Deserialize<data>(json);
            Console.WriteLine("file loaded succesfully at " + path);
        }
        private DateTime GetLenght()
        {
            DateTime time;
            do
            {
                Console.Write("Length (hh:mm:ss): ");
            }
            while (!DateTime.TryParse("0001-01-01 " + Console.ReadLine(), out time));
            return time;
        }
        private DateTime GetRelease()
        {
            DateTime date;
            string input = "";
            do
            {
                Console.Write("Release Date (dd/mm/yyyy): ");
                input = Console.ReadLine();
                if (input == "") return DateTime.Today;
            }
            while (!DateTime.TryParse(input, out date));
            return date;
        }
        private string Getstring(string type)
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
        private int GetInt(string request)
        {
            int i;
            do
            {
                Console.Write(request);
            }
            while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }
    }
}