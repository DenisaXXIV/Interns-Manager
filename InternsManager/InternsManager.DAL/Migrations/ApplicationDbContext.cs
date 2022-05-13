using InternsManager.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternsManager.DAL.Migrations
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Intern> Interns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Intern>().HasData(
                new Intern
                {
                    Id = 1,
                    Name = "Alexandru Ivanoff",
                    Age = 19,
                    DateOfBirth = "4.05.2002",
                    Gender = "M",
                    PicPath = ""
                },
                new Intern
                {
                    Id = 2,
                    Name = "Irina Defta",
                    Age = 22,
                    DateOfBirth = "12.11.2000",
                    Gender = "F",
                    PicPath = ""
                });

        }
    }
}
