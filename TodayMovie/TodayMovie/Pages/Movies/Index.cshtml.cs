using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using TodayMovie.Data;

namespace TodayMovie.Pages_Movies
{
    public class IndexModel : PageModel
    {
        private readonly TodayMovie.Data.TodayMovieContext _context;

        public IndexModel(TodayMovie.Data.TodayMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
