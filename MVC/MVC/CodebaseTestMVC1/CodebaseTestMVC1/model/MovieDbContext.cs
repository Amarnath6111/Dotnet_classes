using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodebaseTestMVC1.model
{
    class MovieDbContext: DbContext
    {
        public MovieDbContext():base("name=MovieContext")
        {

        }
        public DbSet<Movie> Movies { get; set; }

    }
}
