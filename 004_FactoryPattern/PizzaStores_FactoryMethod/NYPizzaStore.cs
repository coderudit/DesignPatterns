using System;
using _004_FactoryPattern.PizzaIngredients_Factory;
using _004_FactoryPattern.PizzaTypes;

namespace _004_FactoryPattern.PizzaStores_Factory
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore()
        {
        }
        protected override Pizza CreatePizza(PizzaType pizzaType)
        {
            Pizza pizza = pizzaType switch
            {
                PizzaType.Cheese => new NYCheesePizza(new NYPizzaIngredient()),
                PizzaType.Marghereita => new NYMarghereitaPizza(new NYPizzaIngredient()),
                PizzaType.Indian => new NYIndianPizza(new NYPizzaIngredient()),
                PizzaType.Mexican => new NYMexicanPizza(new NYPizzaIngredient()),
                _ => throw new NotImplementedException()
            };
            return pizza;
        }
    }
}
