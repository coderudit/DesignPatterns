using System;
using _004_FactoryPattern.PizzaIngredients_Factory;

namespace _004_FactoryPattern.PizzaTypes
{
    public class NYMexicanPizza: Pizza
    {
        IPizzaIngredient _pizzaIngredient;
        //public NYMexicanPizza()
        //{
        //    Name = "NY Style Mexican Pizza";
        //    Dough = "Thin Crust Dough";
        //    Sauce = "Marinara Sauce";
        //    toppings.Add("Grated Reggiano Cheese");
        //}

        public NYMexicanPizza(IPizzaIngredient pizzaIngredient)
        {
            _pizzaIngredient = pizzaIngredient;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _pizzaIngredient.CreateDough();
            Sauce = _pizzaIngredient.CreateSauce();
            Cheese = _pizzaIngredient.CreateCheese();
            Clams = _pizzaIngredient.CreateClams();
            Veggies = _pizzaIngredient.CreateVeggies();
        }
    }
    public class ChicagoMexicanPizza : Pizza
    {
        IPizzaIngredient _pizzaIngredient;
        //public ChicagoMexicanPizza()
        //{
        //    Name = "Chicago Style Mexican Pizza";
        //    Dough = "Thin Crust Dough";
        //    Sauce = "Marinara Sauce";
        //    toppings.Add("Grated Reggiano Cheese");
        //}

        public ChicagoMexicanPizza(IPizzaIngredient pizzaIngredient)
        {
            _pizzaIngredient = pizzaIngredient;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _pizzaIngredient.CreateDough();
            Sauce = _pizzaIngredient.CreateSauce();
            Cheese = _pizzaIngredient.CreateCheese();
            Clams = _pizzaIngredient.CreateClams();
            Veggies = _pizzaIngredient.CreateVeggies();
        }
    }
}
