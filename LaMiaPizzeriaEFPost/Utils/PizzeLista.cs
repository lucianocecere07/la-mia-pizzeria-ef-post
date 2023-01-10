using LaMiaPizzeriaEFPost.Models;

namespace LaMiaPizzeriaEFPost.Utils
{
    public static class PizzeLista
    {
        private static List<Pizza> pizze;

        public static List<Pizza> Pizze()
        {
            if (pizze != null)
            {
                return pizze;
            }

            pizze = new List<Pizza>();

            Pizza pizza1 = new Pizza(1, "Margherita", "pomodoro, mozzarella e basilico", "/img/pizza-margherita.jpg", 5.50);
            Pizza pizza2 = new Pizza(2, "Marinara", "pomodoro, aglio, origano e olio", "/img/pizza-marinara.jpg", 5.00);
            Pizza pizza3 = new Pizza(3, "Diavola", "pomodoro, mozzarella, basilico e salame piccante", "/img/pizza-diavola.jpg", 6.50);
            Pizza pizza4 = new Pizza(4, "Napoli", "pomodoro, mozzarella e alici", "/img/pizza-napoli.jpg", 6.50);
            Pizza pizza5 = new Pizza(5, "Crostino", "mozzarella e prosciutto cotto", "/img/pizza-crostino.jpg", 6.00);
            Pizza pizza6 = new Pizza(6, "Ortolana", "mozzarella, zucchine, peperoni e funghi", "/img/pizza-ortolana.jpg", 7.00);

            pizze.Add(pizza1);
            pizze.Add(pizza2);
            pizze.Add(pizza3);
            pizze.Add(pizza4);
            pizze.Add(pizza5);
            pizze.Add(pizza6);

            return pizze;
        }
    }
}
