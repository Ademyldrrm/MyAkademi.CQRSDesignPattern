using Microsoft.EntityFrameworkCore;
using MyAkademi.CQRSDesignPattern.DAL.Entities;

namespace MyAkademi.CQRSDesignPattern.DAL.Context
{
    public class SaleContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-40G2DNI\\SQLEXPRESS;initial Catalog=CQRSDb;integrated Security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
