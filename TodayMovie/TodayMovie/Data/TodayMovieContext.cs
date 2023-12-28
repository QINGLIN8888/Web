using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodayMovie.Models;

namespace TodayMovie.Data
{
    public class TodayMovieContext : DbContext
    {
        public TodayMovieContext (DbContextOptions<TodayMovieContext> options)
            : base(options)
        {
        }

        public DbSet<TodayMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
