using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Threading;

namespace PizzaTime
{
    class User
    {
        String name;

        private List<int> MyOrders = new List<int>();

        private List<Pizza> _myPizzas = new List<Pizza>();

        public User(string name)
        {
            this.name = name;
        }

        public List<Pizza> MyPizzas
        {
            get
            {
                return _myPizzas;
            }
        }

        public void OrderPizza(PizzaType pizzaType, PizzeriaClass pizzeria)
        {
            Guid PizzaId = pizzeria.OrderPizza(pizzaType);

            WaitMyPizza(PizzaId, pizzeria);
        }

        private void WaitMyPizza(Guid PizzaId, PizzeriaClass pizzeria)
        {
            Pizza MyPizza;

            do
            {
                MyPizza = pizzeria.TryGetPizza(PizzaId);
                Thread.Sleep(3000);
            }
            while (MyPizza == null);

            _myPizzas.Add(MyPizza);
            Console.WriteLine("Ура, сейчас покушаю!");
        }
    }
}
