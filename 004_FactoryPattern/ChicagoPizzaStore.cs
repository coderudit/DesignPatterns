using System;

namespace _004_FactoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                PizzaType.Cheese => new ChicagoStyleCheesePizza(),
                PizzaType.Marghereita => new ChicagoMarghereitaPizza(),
                PizzaType.Indian => new ChicagoIndianPizza(),
                PizzaType.Mexican => new ChicagoMexicanPizza(),
                _ => throw new NotImplementedException()
            };
            return pizza;
        }
    }
}
