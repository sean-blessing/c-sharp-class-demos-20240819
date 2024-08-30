using System.Reflection;

namespace Proj08MoviesArray {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Movie Array App!");

            var swMovie = (id:1, title:"Star Wars Episode IV: A New Hope", year: 1977, 
                rating: "PG", director: "George Lucas");
            var btfMovie = (id: 2, title: "Back to the Future", year: 1985,
                rating: "PG", director: "Robert Zemeckis");
            var wcMovie = (id: 3, title: "Wedding Crashers", year: 2005,
                rating: "R", director: "David Dobkin");
            var sbMovie = (id: 4, title: "Step Brothers", year: 2008,
                rating: "R", director: "Adam McKay");
            var hgMovie = (id: 5, title: "Happy Gilmore", year: 1996,
                rating: "PG-13", director: "Dennis Dugan");
            //var newMovie = (title: "New Movie", runTime: 109);

            var movies = new[] {swMovie, btfMovie, wcMovie, sbMovie, hgMovie };

            foreach (var movie in movies) {
                Console.WriteLine($"Movie: {movie.title} ({movie.year}), rated {movie.rating}, directed by {movie.director}");
            }

            Console.WriteLine("bye");
        }
    }
}
