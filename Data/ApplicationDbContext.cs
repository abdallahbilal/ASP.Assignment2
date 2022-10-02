using Assignment2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Assignment2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Teams> Teams { get; set; }

        public DbSet<Players> Players { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}