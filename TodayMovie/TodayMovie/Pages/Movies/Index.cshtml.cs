using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TodayMovie.Models;
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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Title { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieTitle { get; set; }
        
        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie
                 select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            Movie = await movies.ToListAsync();
        }
    }
}
