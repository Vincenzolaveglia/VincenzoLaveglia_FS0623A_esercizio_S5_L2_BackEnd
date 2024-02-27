using Gestionale_Edile.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gestionale_Edile.Controllers
{
    public class PagamentoController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDbPayments.GetAll());
        }

        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(DateTime Periodo, double Totale, string TipoPagamento, int DipendenteId)
        {
            var pagamento = StaticDbPayments.Add(Periodo, Totale, TipoPagamento, DipendenteId);
            return RedirectToAction("Index", new { id = pagamento.Id });
        }
    }
}
