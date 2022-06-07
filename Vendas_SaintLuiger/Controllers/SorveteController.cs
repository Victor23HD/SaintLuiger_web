using Microsoft.AspNetCore.Mvc;
using Vendas_SaintLuiger.Models;
using Vendas_SaintLuiger.Repositories.Interfaces;


namespace Vendas_SaintLuiger.Controllers
{
    public class SorveteController : Controller
    {

        private readonly ISorveteRepository _sorveteRepository;

        public SorveteController(ISorveteRepository sorveteRepository)
        {
            _sorveteRepository = sorveteRepository;
        }

        public IActionResult List()
        {

            ViewData["Title"] = "Sorvetes |";
            var Sorvetes = _sorveteRepository.Sorvetes;
            return View(Sorvetes);
        }

    }
}
