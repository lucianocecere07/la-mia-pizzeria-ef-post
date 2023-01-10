using LaMiaPizzeriaEFPost.Models;
using LaMiaPizzeriaEFPost.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
 

namespace LaMiaPizzeriaEFPost.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            List<Pizza> listaPizza = PizzeLista.Pizze();
            return View("Index", listaPizza);
        }

        public IActionResult Dettagli(int idScelto)
        {
            List<Pizza> listaPizza = PizzeLista.Pizze();
            foreach (Pizza pizza in listaPizza)
            {
                if (pizza.Id == idScelto)
                {
                    return View(pizza);
                }
            }

            return NotFound("Questa pizza non esiste");
        }

        [HttpGet]
        public IActionResult Aggiungi()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Aggiungi(Pizza NuovaPizza)
        {

        }

    }
}
