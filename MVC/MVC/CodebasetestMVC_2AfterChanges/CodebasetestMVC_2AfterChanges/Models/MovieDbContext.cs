using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodebasetestMVC_2AfterChanges.Models
{
    public class MovieDbContext:DbContext
    {
        public MovieDbContext() : base("name=MovieContext")
        {

        }
        public DbSet<Movie> Movies { get; set; }
    }
}