using Microsoft.EntityFrameworkCore;
using Vendas_SaintLuiger.Models;

namespace Vendas_SaintLuiger.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Sorvete> Sorvetes { get; set; }
    }
}
