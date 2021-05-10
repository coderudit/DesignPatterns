using System;

namespace _004_FactoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                PizzaType.Cheese => new NYStyleCheesePizza(),
                PizzaType.Marghereita => new NYMarghereitaPizza(),
                PizzaType.Indian => new NYIndianPizza(),
                PizzaType.Mexican => new NYMexicanPizza(),
                _ => throw new NotImplementedException()
            };
            return pizza;
        }
    }
}
