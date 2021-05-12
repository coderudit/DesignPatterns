using System;
using _004_FactoryPattern.PizzaIngredients_Factory;

namespace _004_FactoryPattern.PizzaTypes
{
    public class NYMarghereitaPizza: Pizza
    {
        IPizzaIngredient _pizzaIngredient;
        //public NYMarghereitaPizza()
        //{
        //    Name = "NY Style Marghereita Pizza";
        //    Dough = "Thin Crust Dough";
        //    Sauce = "Marinara Sauce";
        //    toppings.Add("Grated Reggiano Cheese");
        //}

        public NYMarghereitaPizza(IPizzaIngredient pizzaIngredient)
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

    public class ChicagoMarghereitaPizza : Pizza
    {
        IPizzaIngredient _pizzaIngredient;
        //public ChicagoMarghereitaPizza()
        //{
        //    Name = "Chicago Marghereita Pizza";
        //    Dough = "Thin Crust Dough";
        //    Sauce = "Marinara Sauce";
        //    toppings.Add("Grated Reggiano Cheese");

        //}

        public ChicagoMarghereitaPizza(IPizzaIngredient pizzaIngredient)
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
