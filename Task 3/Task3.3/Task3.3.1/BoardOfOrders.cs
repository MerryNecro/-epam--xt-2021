using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaTime
{
    class BoardOfOrders
    {
        private BoardOfOrders _orderBoard;

        private Dictionary<Guid, Pizza> CookedPizzas = new Dictionary<Guid, Pizza>();

        public BoardOfOrders OrderBoard
        {
            get
            {
                if (_orderBoard == null)
                {
                    _orderBoard = new BoardOfOrders();
                }
                return this._orderBoard;
            }
        }

        public void AddCookedPizza(Guid PizzaId, Pizza cookedPizza)
        {
            Console.WriteLine("Your " + cookedPizza.Type + " is ready!");
            CookedPizzas.Add(PizzaId, cookedPizza);
        }

        public Pizza ContainsPizza(Guid PizzaId)
        {
            if (CookedPizzas.ContainsKey(PizzaId))
            {
                return CookedPizzas[PizzaId];
            }
            else return null;
        }
    }
}
