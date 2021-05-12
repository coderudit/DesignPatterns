using System;
using _004_FactoryPattern.PizzaIngredients_Factory;
using _004_FactoryPattern.PizzaTypes;

namespace _004_FactoryPattern.PizzaStores_Factory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                PizzaType.Cheese => new ChicagoCheesePizza(new ChicagoPizzaIngredient()),
                PizzaType.Marghereita => new ChicagoMarghereitaPizza(new ChicagoPizzaIngredient()),
                PizzaType.Indian => new ChicagoIndianPizza(new ChicagoPizzaIngredient()),
                PizzaType.Mexican => new ChicagoMexicanPizza(new ChicagoPizzaIngredient()),
                _ => throw new NotImplementedException()
            };
            return pizza;
        }
    }
}
