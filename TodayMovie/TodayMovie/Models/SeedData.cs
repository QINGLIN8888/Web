using Microsoft.EntityFrameworkCore;
using TodayMovie.Data;

namespace TodayMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new TodayMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<TodayMovieContext>>()))
        {
            if (context == null || context.Movie == null)
            {
                throw new ArgumentNullException("Null TodayMovieContext");
            }

            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(
                new Movie
                {
                    Title = "訓龍高手",
                    ReleaseDate = DateTime.Parse("2010-3-26"),
                    Price = 7.99M,
                    Rating = "O"
                },

                new Movie
                {
                    Title = "鬼修女1 ",
                    ReleaseDate = DateTime.Parse("2018-9-07"),
                    Price = 8.99M,
                    Rating = "15"
                },

                new Movie
                {
                    Title = "鬼修女2",
                    ReleaseDate = DateTime.Parse("2023-9-08"),
                    Price = 9.99M,
                    Rating = "15"
                },

                new Movie
                {
                    Title = "訓龍高手2",
                    ReleaseDate = DateTime.Parse("2014-6-13"),
                    Price = 3.99M,
                    Rating = "O"
                }
            );
            context.SaveChanges();
        }
    }
}