using Gestionale_Edile.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gestionale_Edile.Controllers
{
    public class DipendenteController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDb.GetAll());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string Nome, string Cognome, string Indirizzo, string CF, bool Coniugato, int FigliACarico, string Mansione)
        {
            var dipendente = StaticDb.Add(Nome, Cognome, Indirizzo, CF, Coniugato, FigliACarico, Mansione);
            return RedirectToAction("Index", new {id = dipendente.Id });
        }
    }
}
