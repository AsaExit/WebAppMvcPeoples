using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models;

namespace WebAppMvcPeoples.Data
{
    public class PeopleDbContext:DbContext
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        { }
        
           public DbSet<Person> People{ get; set; }
           public DbSet<City> Cities { get; set; }
           public DbSet<Country> Countries { get; set; }

    }
}
