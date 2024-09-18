using Ch20EntityFrameworkCorePrep.Db;
using Ch20EntityFrameworkCorePrep.Models;

namespace Ch20EntityFrameworkCorePrep {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to Chapter 20, EF Core!");
            MovieDb movieDb = new();

            Console.WriteLine("Get all movies:");
            List<Movie> movies = movieDb.GetMovies();
            foreach (Movie m in movies) {
                Console.WriteLine($"{m.ToString()}");
            }
            Console.WriteLine("-------------------------");
            //Console.WriteLine("Add a movie:");
            //Movie m1 = new Movie("test movie1", 2000, "PG", "Stan Lee");
            //movieDb.AddMovie(m1);
            //Console.WriteLine($"movie added: {m1.ToString()}");
            //Console.WriteLine("-------------------------");
            Console.WriteLine("Get a movie:");
            int movieId = 4; 
            Movie m2 = movieDb.FindMovie(movieId);
            Console.WriteLine($"movie retrieved for id{movieId}: {m2.ToString()}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Update a movie:");
            m2.Title = "Updated Title m2";
            movieDb.UpdateMovie(m2);
            m2 = movieDb.FindMovie(movieId);
            Console.WriteLine($"movie updated for id{movieId}: {m2.ToString()}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Delete a movie:");
            movieDb.RemoveMovie(m2);
            Console.WriteLine($"movie removed for id{movieId}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Get all movies:");
            movies = movieDb.GetMovies();
            foreach (Movie m in movies) {
                Console.WriteLine($"{m.ToString()}");
            }
            Console.WriteLine("-------------------------");



            Console.WriteLine("=========================");
            ActorDb actorDb = new();

            Console.WriteLine("Get all actors:");
            List<Actor> actors = actorDb.GetActors();
            foreach (Actor a in actors) {
                Console.WriteLine($"{a.ToString()}");
            }
            Console.WriteLine("=========================");
            CreditDb creditDb = new();

            Console.WriteLine("Get all credits:");
            List<Credit> credits = creditDb.GetCredits();
            foreach (Credit c in credits) {
                Console.WriteLine($"{c.ToString()}");
            }
            Console.WriteLine("=========================");

            Console.WriteLine("Bye");
        }
    }
}
