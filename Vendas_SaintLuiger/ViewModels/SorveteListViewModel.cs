using Vendas_SaintLuiger.Models;

namespace Vendas_SaintLuiger.ViewModels
{
    public class SorveteListViewModel
    {
        public IEnumerable<Sorvete> Sorvetes { get; set; }
        public string CategoriaAtual { get; set; }

    }
}
