using System;
using _004_FactoryPattern.PizzaIngredients_Factory;

namespace _004_FactoryPattern.PizzaTypes
{
    public class NYIndianPizza: Pizza
    {
        IPizzaIngredient _pizzaIngredient;
        //public NYIndianPizza()
        //{
        //    Name = "NY Style India Pizza";
        //    Dough = "Thin Crust Dough";
        //    Sauce = "Marinara Sauce";
        //    toppings.Add("Grated Reggiano Cheese");
        //}

        public NYIndianPizza(IPizzaIngredient pizzaIngredient)
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

    public class ChicagoIndianPizza : Pizza
    {
        IPizzaIngredient _pizzaIngredient;
        //public ChicagoIndianPizza()
        //{
        //    Name = "Chicago Style Indian Pizza";
        //    Dough = "Thin Crust Dough";
        //    Sauce = "Marinara Sauce";
        //    toppings.Add("Grated Reggiano Cheese");
        //}

        public ChicagoIndianPizza(IPizzaIngredient pizzaIngredient)
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
