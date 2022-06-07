using Vendas_SaintLuiger.Models;

namespace Vendas_SaintLuiger.Repositories.Interfaces
{
    public interface ISorveteRepository
    {
        IEnumerable<Sorvete> Sorvetes { get;}
        IEnumerable<Sorvete> SorvetesPreferidos { get; }

        Sorvete GetSorveteById(int sorveteId);
    }
}
