using Microsoft.AspNetCore.Mvc;
using Parcial_MVC.Models;

namespace Parcial_MVC.Controllers
{
    public class DadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calcular(Dado obdado)
        {
            Random rnd = new Random();

            obdado.NumeroGenerado = rnd.Next(1, 10);

            return View("Resultado", obdado);
        }
    }
}
