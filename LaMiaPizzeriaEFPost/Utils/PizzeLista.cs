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

            Pizza pizza1 = new Pizza("Margherita", "pomodoro, mozzarella e basilico", "/img/pizza-margherita.jpg", 5.50);
            Pizza pizza2 = new Pizza("Marinara", "pomodoro, aglio, origano e olio", "/img/pizza-marinara.jpg", 5.00);
            Pizza pizza3 = new Pizza("Diavola", "pomodoro, mozzarella, basilico e salame piccante", "/img/pizza-diavola.jpg", 6.50);
            Pizza pizza4 = new Pizza("Napoli", "pomodoro, mozzarella e alici", "/img/pizza-napoli.jpg", 6.50);
            Pizza pizza5 = new Pizza("Crostino", "mozzarella e prosciutto cotto", "/img/pizza-crostino.jpg", 6.00);
            Pizza pizza6 = new Pizza("Ortolana", "mozzarella, zucchine, peperoni e funghi", "/img/pizza-ortolana.jpg", 7.00);

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
