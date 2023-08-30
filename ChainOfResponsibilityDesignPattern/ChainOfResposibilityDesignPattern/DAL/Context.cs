using ChainOfResposibilityDesignPattern.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChainOfResposibilityDesignPattern.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=YASIN;Database=ChainORDb; Trusted_Connection=True;");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
