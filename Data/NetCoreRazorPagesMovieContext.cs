using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreRazorPagesMovie.Models;

namespace NetCoreRazorPagesMovie.Data
{
    public class NetCoreRazorPagesMovieContext : DbContext
    {
        public NetCoreRazorPagesMovieContext (DbContextOptions<NetCoreRazorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreRazorPagesMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
