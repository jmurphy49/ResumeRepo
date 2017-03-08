using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ResumePage.Models;

namespace ResumePage.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public ApplicationDbContext()
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Job>().ToTable("Jobs");
            modelBuilder.Entity<Education>().ToTable("Educations");
            modelBuilder.Entity<People>().ToTable("Peoples");
            modelBuilder.Entity<Reference>().ToTable("References");

        }

        public DbSet<Job> Job { get; set; }

        public DbSet<Education> Education { get; set; }

        public DbSet<People> People { get; set; }
        public DbSet<Reference> Reference { get; set; }
    }
}
