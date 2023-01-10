using LaMiaPizzeriaEFPost.DataBase;
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
            using (PizzeriaContext db = new PizzeriaContext())
            {
                List<Pizza> listaPizza = db.Pizza.ToList<Pizza>();

                return View("Index", listaPizza);
            }
        }

        public IActionResult Dettagli(int idScelto)
        {
            using (PizzeriaContext db = new PizzeriaContext())
            {
                //LINQ Method synthax
                Pizza pizzaScelta = db.Pizza
                    .Where(pizza => pizza.Id == idScelto)
                    .FirstOrDefault();

                if (pizzaScelta != null)
                {
                    return View(pizzaScelta);
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
            if (!ModelState.IsValid)
            {
                return View("Aggiungi", NuovaPizza);
            }

            using (PizzeriaContext db = new PizzeriaContext())
            {
                db.Pizza.Add(NuovaPizza);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
