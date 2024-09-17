using Ch20EFBmdbConsole.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch20EFBmdbConsole.Db {
    public class MovieDb {
        private BmdbContext dbContext = new();
        
        // CRUD Methods
        public List<Movie> GetMovies() {
            return dbContext.Movies.ToList();
        }
        public Movie FindMovie(int id) {
            return dbContext.Movies.Where(m => m.Id == id).FirstOrDefault();
        }

        public void AddMovie(Movie movie) {
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
        }

        public void UpdateMovie(Movie movie) {
            dbContext.SaveChanges();
        }

        public void RemoveMovie(Movie movie) {
            dbContext.Movies.Remove(movie);
            dbContext.SaveChanges();
        }

    }


}
