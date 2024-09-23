using Microsoft.EntityFrameworkCore;
using PrepWebEFMovieProject.Models;

namespace PrepWebEFMovieProject {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<BmdbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("BmdbConnectionString")));
            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
