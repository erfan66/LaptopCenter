using LaptopCenter.Models;
using Microsoft.EntityFrameworkCore;

namespace LaptopCenter.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-OL8GL33\\SQL2019;Database=LaptopCenter;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Laptop> Laptops { get; set; }
    }
}
