using Ch20EFBmdbConsole.Db;
using Ch20EFBmdbConsole.Models;

namespace Ch20EFBmdbConsole {
    internal class Program {
        static MovieDb movieDb = new();
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Entity Framework, the BMDB Manager!\n");

            string command = "";
            while (command != "exit") { 
                DisplayMenu();
                command = PromptInput("Command: ");

                switch (command) {
                    case "list":
                        ListMovies();
                        break;
                    case "get":
                        GetMovie();
                        break;
                    case "add":
                        AddMovie();
                        break;
                    case "del":
                        DeleteMovie();
                        break;
                    case "exit":
                        break;
                    default: 
                        Console.WriteLine("Invalid command. Try again.");
                        break;
                }
            }
            Console.WriteLine("Bye");
        }

        private static void ListMovies() {
            Console.WriteLine("\nMovies List:");
            Console.WriteLine("=================================");
            List<Movie> movies = movieDb.GetMovies();
            foreach (Movie movie in movies) {
                Console.WriteLine(movie);
            }

        }

        private static void GetMovie() {
            Console.WriteLine("\nGet Movie By ID:");
            Console.WriteLine("=================================");
            int id = Int32.Parse(PromptInput("Movie ID: "));
            Movie m = movieDb.FindMovie(id);
            if (m != null) {
                Console.WriteLine($"Movie Found: {m}");
            }
            else {
                Console.WriteLine($"No movie found for id: {id}");
            }

        }

        private static void AddMovie() {
            Console.WriteLine("\nAdd a Movie:");
            Console.WriteLine("=================================");
            string title = PromptInput("Movie Title: ");
            int year = Int32.Parse(PromptInput("Release Year: "));
            string rating = PromptInput("Age Rating: ");
            string director = PromptInput("Director: ");
            Movie m = new Movie(title, year, rating, director);
            movieDb.AddMovie(m);
            Console.WriteLine($"Movie added: {m}");
        }

        private static void DeleteMovie() {
            Console.WriteLine("\nDelete a Movie:");
            Console.WriteLine("=================================");
            int id = Int32.Parse(PromptInput("Movie ID: "));
            Movie m = movieDb.FindMovie(id);
            if (m != null) {
                movieDb.RemoveMovie(m);
                Console.WriteLine($"Movie Deleted");
            }
            else {
                Console.WriteLine($"No movie found for id: {id}");

            }
        }

        static string PromptInput(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static void DisplayMenu() {
            Console.WriteLine("MENU:");
            Console.WriteLine("===============");
            Console.WriteLine("list - list all movies");
            Console.WriteLine("get  - get a movie by id");
            Console.WriteLine("add  - add a movie");
            Console.WriteLine("del  - delete a movie");
            Console.WriteLine("exit - exit application");
        }
    }
}
