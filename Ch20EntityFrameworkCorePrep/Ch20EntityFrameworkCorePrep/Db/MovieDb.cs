using Ch20EntityFrameworkCorePrep.Models;

namespace Ch20EntityFrameworkCorePrep.Db {
    public class MovieDb {
        private bmdbContext context = new();

        public List<Movie> GetMovies() { 
            return context.Movies.ToList();
        }

        public Movie FindMovie(int id) {
            return context.Movies.Where(x => x.Id == id).FirstOrDefault();
        }

        public void AddMovie(Movie movie) {
            context.Movies.Add(movie);
            context.SaveChanges();
        }

        public void UpdateMovie(Movie movie) {
            context.SaveChanges();
        }

        public void RemoveMovie(Movie movie) {
            context.Movies.Remove(movie); 
            context.SaveChanges();
        }
    }
}
