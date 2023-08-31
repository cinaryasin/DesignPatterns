using CQRSDesignPattern.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSDesignPattern.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YASIN;Database=CQRSDb; Trusted_Connection=True;");
        }
        public DbSet<Product> Products { get; set; }
    }
}
