namespace BackAgain
{
    public class Program
    {
        static void Main(string[] args)
        {
            var movieList = new MovieList();
            while (true)
            {
                MainMenu(movieList);
            }
        }

        static void MainMenu(MovieList movieList)
        {
            Console.WriteLine("1) Show movies");
            Console.WriteLine("2) Add new movie");
            Console.WriteLine("3) Show category");
            movieList.MainMenuInputs();
        }


    }
}