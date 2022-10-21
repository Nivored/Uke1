using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackAgain;
using System.Xml.Linq;

namespace BackAgain
{
    public class MovieList
    {
        public List<Movies> movieList { get; set; }

        public MovieList()
        {
            movieList = new List<Movies>()
            {
                new Movies("Deadpool", "Dying man become the hero and win the girl", Movies.Categorys.Action),
                new Movies("Scream", "People dying left, right and center", Movies.Categorys.Horror),
                new Movies("LOTR", "9 men and children walking far away just to thos a ring", Movies.Categorys.Fantasy),
                new Movies("Die Hard", "Old man trying not to die", Movies.Categorys.Action),
                new Movies("Central intelegence", "2 guys fucking around breaking the USA", Movies.Categorys.Comedy),
                new Movies("Hobbiten", "Some dwarfs, a wizzard and a small man walking on the mountains", Movies.Categorys.Fantasy)
            };
        }

        public void AddNewMovie()
        {
            Console.WriteLine("Add Name");
            var inputName = Console.ReadLine();
            Console.WriteLine("Add Description");
            var inputDescription = Console.ReadLine();
            Console.WriteLine("Add Category");
            var inputCategory = Console.ReadLine();

            var category = (Movies.Categorys)Enum.Parse(typeof(Movies.Categorys), inputCategory);
            movieList.Add(new Movies(inputName, inputDescription, category));
        }

        public void MyMovieList()
        {

            var userInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            foreach (var movie in movieList)
            {
                var cat = movie.Category;

                if (userInput == 1 && cat == Movies.Categorys.Action) movie.PrintMovie();
                if (userInput == 2 && cat == Movies.Categorys.Adventure) movie.PrintMovie();
                if (userInput == 3 && cat == Movies.Categorys.Comedy) movie.PrintMovie();
                if (userInput == 4 && cat == Movies.Categorys.Drama) movie.PrintMovie();
                if (userInput == 5 && cat == Movies.Categorys.Fantasy) movie.PrintMovie();
                if (userInput == 6 && cat == Movies.Categorys.Horror) movie.PrintMovie();
                if (userInput == 7 && cat == Movies.Categorys.Romance) movie.PrintMovie();
                if (userInput == 8 && cat == Movies.Categorys.SiFi) movie.PrintMovie();
                if (userInput == 9 && cat == Movies.Categorys.Thriller) movie.PrintMovie();
            }
        }

        public void ShowAllMovies()
        {
            foreach (var movie in movieList)
            {
                movie.PrintMovie();
            }
        }
        public void MenuOptions()
        {
            Console.WriteLine("1) Action Movies");
            Console.WriteLine("2) Adventure Movies");
            Console.WriteLine("3) Comdey Movies");
            Console.WriteLine("4) Drama Movies");
            Console.WriteLine("5) Fantasy Movies");
            Console.WriteLine("6) Horror Movies");
            Console.WriteLine("7) Romance Movies");
            Console.WriteLine("8) SiFi Movies");
            Console.WriteLine("9) Thriller Movies");
            MyMovieList();
        }


        public void MainMenuInputs()
        {
            var userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    ShowAllMovies();
                    break;
                case "2":
                    AddNewMovie();
                    break;
                case "3":
                    MenuOptions();
                    break;
            }
        }
    }
}