using Vendas_SaintLuiger.Models;

namespace Vendas_SaintLuiger.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
