namespace MoviesWebApi.Models {
    public class Movie {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }

        public Movie(int id, string title, int year, string rating, string director) {
            Id = id;
            Title = title;
            Year = year;
            Rating = rating;
            Director = director;
        }

        public string GetDetails() {
            return $"Movie - Id:{Id}, Title:{Title}, Year:{Year}, Rating:{Rating}, Director:{Director}";
        }
    }
}
