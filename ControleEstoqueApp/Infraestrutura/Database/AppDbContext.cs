using ControleEstoqueApp.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoqueApp.Infraestrutura.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "estoque.db");
            Console.WriteLine($"Banco de dados em: {path}");
            options.UseSqlite($"Data Source={path}");
        }
    }
}
