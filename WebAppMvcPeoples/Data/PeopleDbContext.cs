using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMvcPeoples.Models;
using Microsoft.AspNetCore.Identity;

namespace WebAppMvcPeoples.Data
{
    public class PeopleDbContext:IdentityDbContext<AppUser>
    {
        public PeopleDbContext(DbContextOptions<PeopleDbContext> options) : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonLanguage>().HasKey(dtk => new
            {
                dtk.PersonId,
                dtk.LanguageId
            });

            // Join-table many-to-manyrelationship


            modelBuilder.Entity<PersonLanguage>() // One Person to Many Languages
                .HasOne(dtk => dtk.Person)
                .WithMany(dt => dt.PersonLanguages)
                .HasForeignKey(dtk => dtk.PersonId);

            modelBuilder.Entity<PersonLanguage>()  // One Language to Many People
                .HasOne(dtk => dtk.Language)
                .WithMany(dt => dt.PersonLanguages)
                .HasForeignKey(dtk => dtk.LanguageId);

        }
        public DbSet<Person> People { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<PersonLanguage> PersonLanguages { get; set; }
    }

}

