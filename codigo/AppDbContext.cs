using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using WpfAppHamburgueseria.Models;

namespace WpfAppHamburgueseria.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Hamburguesas> Hamburguesas { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=NBBGG158\\SQLEXPRESS;Database=HamburgueseriaDB;User Id=admin;Password=Hamburguesa*2025;"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
       
        }
    }
}