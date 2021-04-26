using System;

namespace PizzaTime
{
    class Program
    {
        static void Main(string[] args)
        {
            User newUser = new User("Vasya");
            newUser.OrderPizza(PizzaType.margarita, new PizzeriaClass());
        }
    }
}
