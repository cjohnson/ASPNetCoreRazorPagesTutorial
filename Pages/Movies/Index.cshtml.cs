using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNetCoreRazorPagesTutorial.Data;
using ASPNetCoreRazorPagesTutorial.Models;

namespace ASPNetCoreRazorPagesTutorial.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ASPNetCoreRazorPagesTutorial.Data.ASPNetCoreRazorPagesTutorialContext _context;

        public IndexModel(ASPNetCoreRazorPagesTutorial.Data.ASPNetCoreRazorPagesTutorialContext context)
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
