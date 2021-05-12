using System;
using _004_FactoryPattern.PizzaIngredients_Factory;

namespace _004_FactoryPattern.PizzaTypes
{
    public class NYCheesePizza : Pizza
    {
        IPizzaIngredient _pizzaIngredient;
        //Factory Method
        //public NYCheesePizza()
        //{
        //    Name = "NY Style Sauce and Cheese Pizza";
        //    Dough = "Thin Crust Dough";
        //    Sauce = "Marinara Sauce";
        //    toppings.Add("Grated Reggiano Cheese");
        //}

        public NYCheesePizza(IPizzaIngredient pizzaIngredient)
        {
            _pizzaIngredient = pizzaIngredient;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            //Instead of NY Store preparing it's own cheese we are getting them common prepared cheese to have consistency
            Dough = _pizzaIngredient.CreateDough(); 
            Sauce = _pizzaIngredient.CreateSauce();
            Cheese = _pizzaIngredient.CreateCheese();
        }
    }

    public class ChicagoCheesePizza : Pizza
    {
        IPizzaIngredient _pizzaIngredient;
        //public ChicagoCheesePizza()
        //{
        //    Name = "Chicago Style Deep Dish Cheese Pizza";
        //    Dough = "“Extra Thick Crust Dough";
        //    Sauce = "Plum Tomato Sauce";
        //    toppings.Add("Shredded Mozzarella Cheese");
        //}

        public ChicagoCheesePizza(IPizzaIngredient pizzaIngredient)
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

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
