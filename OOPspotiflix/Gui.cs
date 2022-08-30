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

        #region movie
        private void Menu()
        {
            Console.WriteLine("1 for movies\n2 for serise\n3 for music\n4 for save\n5 for load");
            // mainmenu that use the indput of numbers you on the keyborad or numpad
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
            //movie menu that use the indput of numbers you on the keyborad or numpad
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
        private void ShowMovie(movie m)
        {
            // show in what movies ther is in the movielist
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
            // showm what data ther is in movielist
            foreach (movie m in data.movielist)
            {
                ShowMovie(m);
            }
        }
        private void AddMovie()
        {
            //how to add a movie in to the movielist
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
            // search after a specific movie by title or genre
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
        #endregion
        #region series
        private void SeriesMenu()
        {
            //series menu that use the indput of numbers you on the keyborad or numpad
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
            // add a series to the serieslist
            Series series = new Series();
            series.Title = Getstring("Title: ");
            series.Genre = Getstring("Genre: ");
            series.WWW = Getstring("WWW: ");
            series.ReleaseDate = GetRelease();

            Console.WriteLine("add Series (Y/N)");
            if (Console.ReadKey().Key == ConsoleKey.Y) data.serieslist.Add(series);

            Console.WriteLine("add episode?");
            if (Console.ReadKey().Key == ConsoleKey.Y) AddEpisode(series);

        }
        private void AddEpisode(Series series)
        {
            //add a episode to a series
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
            while (Console.ReadKey().Key == ConsoleKey.Y);


        }
        private void ShowSeries(Series s)
        {
            // shows title,genre,releasedate adn wher you can watch it as well the episode title adn releasedate 
            Console.WriteLine($"{s.Title}{s.Genre}{s.GetReleaseDate}{s.WWW}");
            foreach(Episode e in s.Episodes)
            {
                Console.WriteLine($"{e.Title}{e.GetReleaseDate}");
            }
        }
        private void ShowSeriesList()
        {
            // show the list in the series list 
            foreach (Series s in data.serieslist)
            {
                ShowSeries(s);
            }
        }
        private void SearchSeries()
        {
            // searsh after a spesific series in the series list
            Console.WriteLine("search: ");
            string? search = Console.ReadLine();
            foreach (Series series in data.serieslist)
            {
                if (search != null)
                {
                    if (series.Title != search || series.Genre.Contains(search))
                        ShowSeries(series);
                }
            }
        }
        #endregion
        #region music
        private void MusicMenu()
        {
            // music menu that use the indput of numbers you on the keyborad or numpad
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
            // addd a new albun to the list
            Album album = new Album();
            album.Title = Getstring("Album Title: ");
            album.Artist = Getstring("Artist: ");
            album.Genre = Getstring("Genre: ");
            album.ReleaseDate = GetRelease();
            album.WWW = Getstring("WWW: ");

            ShowAlbum(album);
            Console.WriteLine("Add album to list?");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
                data.musiclist.Add(album);

            Console.WriteLine("Add new song to album?");
            while (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                AddSong(album);
                Console.WriteLine("Add another song to album? (y/n)");
            };
        }
        private void AddSong(Album album)
        {
            //add a song to a albun 
            Song song = new Song();
            song.Title = Getstring("Song Title: ");
            song.Artist = GetInputOrParent(album.Artist, "Artist: ");
            song.Genre = GetInputOrParent(album.Genre, "Genre: ");
            song.ReleaseDate = GetRelease();
            song.Length = GetLenght();
            Console.WriteLine("Add this song to album? (y/n)");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
                album.Songs.Add(song);
        }
        private string GetInputOrParent(string parent, string type)
        {
            Console.Write(type);
            string input = Console.ReadLine();
            if (input != "") parent = input;
            return parent;
        }//add comments
        private void ShowMusicList()
        {
            // shows what data ther is in the musie list
            foreach (Album album in data.musiclist)
            {
                ShowAlbum(album, true);
            }
        }
        private void ShowAlbum(Album album, bool showSongs = false)
        {
            //shows what dta ther is in the album
            Console.WriteLine($"Album title: {album.Title}");
            if (showSongs)
            {
                foreach (Song song in album.Songs)
                {
                    ShowSong(song);
                }
            }
        }
        private void ShowSong(Song song)
        {
            //shows what songs ther is by display ther titles
            Console.WriteLine($"{song.Title}");
        }
        private void SearchMusic()
        {
            // search in the musiclist by ther title and genre 
            Console.WriteLine("search: ");
            string? search = Console.ReadLine();
            foreach(Album album in data.musiclist)
            {
                if (search != null)
                {
                    if(album.Title != search||album.Genre.Contains(search))
                        ShowAlbum(album);
                }
            }
        }
        #endregion
        #region data
        private void savedata()
        {
            //saves the input data to a file on the desktop ny using json
            string Json = JsonSerializer.Serialize(data);
            File.WriteAllText(path, Json);
            Console.WriteLine("file saved succesfully at " + path);
        }
        private void LoadData()
        {
            //loading the fil saved on disktop
            string json = File.ReadAllText(path);
            data = System.Text.Json.JsonSerializer.Deserialize<data>(json);
            Console.WriteLine("file loaded succesfully at " + path);
        }
        private DateTime GetLenght()
        {
            //input the lenght by conveting the indput to datetime  and showing it on the console
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
            //input the relasedate of the day it was release and shows it on the console
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
            //a string indput so what you write in the console and saved it
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
            //a string convetet to a int
            int i;
            do
            {
                Console.Write(request);
            }
            while (!int.TryParse(Console.ReadLine(), out i));
            return i;
        }
        #endregion
    }
}