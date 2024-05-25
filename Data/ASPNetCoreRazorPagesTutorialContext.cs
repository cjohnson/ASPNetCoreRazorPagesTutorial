using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPNetCoreRazorPagesTutorial.Models;

namespace ASPNetCoreRazorPagesTutorial.Data
{
    public class ASPNetCoreRazorPagesTutorialContext : DbContext
    {
        public ASPNetCoreRazorPagesTutorialContext (DbContextOptions<ASPNetCoreRazorPagesTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<ASPNetCoreRazorPagesTutorial.Models.Movie> Movie { get; set; } = default!;
    }
}
