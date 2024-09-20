using Microsoft.AspNetCore.Mvc;
using MoviesWebApi.Models;

namespace MoviesWebApi.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase {
        static List<Movie> Movies = new();

        private void InitializeMovies() {
            Movies.AddRange(new List<Movie> {
                new Movie(1, "Star Wars Episode IV - A New Hope", 1977, "PG", "George Lucas"),
                new Movie(2, "Pulp Fiction", 1994, "R", "Quentin Tarantino"),
                new Movie(3, "Evil Dead: Rise", 2023, "R", "Lee Cronin")
            });
        }

        [HttpGet]
        public List<string> GetAllMovies() {
            if (Movies.Count == 0) {
                InitializeMovies();
            }
            List<string> movieStrList = new();
            foreach (var movie in Movies) {
                movieStrList.Add(movie.GetDetails());
            }
            return movieStrList;
        }

        [HttpGet("{id}")]
        public string GetMovieById(int id) {
            Movie? m = FindMovie(id);
            foreach (Movie movie in Movies) {
                if (movie.Id == id) {
                    m = movie;
                    break;
                }    
            }
            if (m != null) {
                return m.GetDetails();
            }
            else {
                return $"No movie exists with id {id}. Try again.";
            }
        }

        private Movie FindMovie(int id) {
            Movie? m = null;
            foreach (Movie movie in Movies) {
                if (movie.Id == id) {
                    m = movie;
                    break;
                }
            }
            return m;
        }

        [HttpPost]
        public string AddMovie(Movie movie) {
            Movies.Add(movie);
            return "Movie added";
        }

        [HttpDelete("{id}")]
        public string RemoveMovie(int id) {
            Movie m = FindMovie(id);
            if (m != null) {
                Movies.Remove(m);
                return "Movie removed.";
            }
            else {
                return $"No movie exists with id {id}. Try again.";
            }
        }

        [HttpPut]
        public string UpdateMovie(Movie movie) {
            Movie m = FindMovie(movie.Id);
            if ( m!= null) {
                m = movie;
                return "Movie updated.";
            }
            else {
                return $"No movie exists with id {movie.Id}. Try again.";
            }

        }
    }
}
