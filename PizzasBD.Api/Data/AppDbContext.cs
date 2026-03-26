using Microsoft.EntityFrameworkCore;
using PizzasBD.Api.Entities;

namespace PizzasBD.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductoEntity>().Property(p => p.Id).ValueGeneratedNever();
            modelBuilder.Entity<MasaEntity>().Property(p => p.Id).ValueGeneratedNever();
            modelBuilder.Entity<MenuEntity>().Property(p => p.Id).ValueGeneratedNever();
            modelBuilder.Entity<TamanioEntity>().Property(p => p.Id).ValueGeneratedNever();
        }

        public DbSet<ProductoEntity> Productos { get; set; }
        public DbSet<MasaEntity> Masas { get; set; }
        public DbSet<MenuEntity> Menus { get; set; }
        public DbSet<TamanioEntity> Tamanios { get; set; }
    }
}
