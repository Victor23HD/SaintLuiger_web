using Microsoft.EntityFrameworkCore;
using Vendas_SaintLuiger.Context;
using Vendas_SaintLuiger.Models;
using Vendas_SaintLuiger.Repositories.Interfaces;

namespace Vendas_SaintLuiger.Repositories
{
    public class SorveteRepository : ISorveteRepository
    {
        private readonly AppDbContext _context;
        public SorveteRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Sorvete> Sorvetes => _context.Sorvetes.Include(c => c.Categoria);

        public IEnumerable<Sorvete> SorvetesPreferidos => _context.Sorvetes.
            Where(i => i.IsSorvetePreferido).Include(c => c.Categoria);

        public Task<object> ToListAsync(IEnumerable<Sorvete> sorvete)
        {
            throw new NotImplementedException();
        }
    }
}
