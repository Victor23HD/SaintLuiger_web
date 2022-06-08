using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Vendas_SaintLuiger.Models;
using Vendas_SaintLuiger.Repositories.Interfaces;
using Vendas_SaintLuiger.ViewModels;


namespace Vendas_SaintLuiger.Controllers
{
    public class SorveteController : Controller
    {

        private readonly ISorveteRepository _sorveteRepository;

        public SorveteController(ISorveteRepository sorveteRepository)
        {
            _sorveteRepository = sorveteRepository;
        }

        public IActionResult List(string categoria)
        {

            IEnumerable<Sorvete> Sorvetes;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                Sorvetes = _sorveteRepository.Sorvetes.OrderBy(l => l.SorveteId);
                categoriaAtual = "Todos os Sorvetes";
            }
            else
            {
                if (string.Equals("Picole Tradicional", categoria, StringComparison.OrdinalIgnoreCase))
                {
                        Sorvetes = _sorveteRepository.Sorvetes
                        .Where(l => l.Categoria.CategoriaNome.Equals("Picole Tradicional"))
                        .OrderBy(l => l.SorveteId);
                }
                else
                {
                    Sorvetes = _sorveteRepository.Sorvetes
                   .Where(l => l.Categoria.CategoriaNome.Equals("Picole Premium"))
                   .OrderBy(l => l.SorveteId);
                }


                categoriaAtual = categoria;
            }

            ViewData["Title"] = "Sorvetes |";

            var SorveteListViewModel = new SorveteListViewModel
            {
                Sorvetes = Sorvetes,
                CategoriaAtual = categoriaAtual
            };

            return View(SorveteListViewModel);
        }
    }
}
