using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PizzaTime
{
    class PizzeriaClass
    {
        private PizzeriaClass _pizzeria;

        private BoardOfOrders OrderBoard = new BoardOfOrders();

        private Dictionary<Guid,Pizza> Orders = new Dictionary<Guid, Pizza>();

        private List<Pizza> ReadyPizza = new List<Pizza>();

        public PizzeriaClass Pizzeria
        {
            get
            {
                if(_pizzeria == null)
                {
                    _pizzeria = new PizzeriaClass();
                }
                return this._pizzeria;
            }
        }

        public Guid OrderPizza(PizzaType pizzaType)
        {
            Guid PizzaId = new Guid();
            Pizza CookingPizza = new Pizza(pizzaType);
            Orders.Add(PizzaId, CookingPizza);
            CookPizza(PizzaId, pizzaType);
            return PizzaId;
        }

        async private void CookPizza(Guid PizzaId,PizzaType pizzaType)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("We started cooking your " + pizzaType);
                Thread.Sleep(9000);
                OrderBoard.AddCookedPizza(PizzaId, new Pizza(pizzaType));
            });
        }

        public Pizza TryGetPizza(Guid PizzaId)
        {
            return OrderBoard.ContainsPizza(PizzaId);
        }
    }
}
