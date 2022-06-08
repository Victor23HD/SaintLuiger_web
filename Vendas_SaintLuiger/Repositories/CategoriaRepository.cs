using Vendas_SaintLuiger.Context;
using Vendas_SaintLuiger.Models;

namespace Vendas_SaintLuiger.Repositories
{
    public class CategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;

    }
}
