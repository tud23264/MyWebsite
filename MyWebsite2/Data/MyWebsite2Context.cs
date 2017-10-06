using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyWebsite2.Models
{
    public class MyWebsite2Context : DbContext
    {
        public MyWebsite2Context (DbContextOptions<MyWebsite2Context> options)
            : base(options)
        {
        }

        public DbSet<MyWebsite2.Models.Movie> Movie { get; set; }
    }
}
