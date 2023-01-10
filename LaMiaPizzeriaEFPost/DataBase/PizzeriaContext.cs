using LaMiaPizzeriaEFPost.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace LaMiaPizzeriaEFPost.DataBase
{
    public class PizzeriaContext : DbContext
    {
        public DbSet<Pizza> Pizza { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=PizzeriaDatabase;" +
            "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
