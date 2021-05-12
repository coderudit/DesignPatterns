using System;
using System.Collections.Generic;
using _004_FactoryPattern.PizzaIngredients;

namespace _004_FactoryPattern.PizzaTypes
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni[] Pepperoni { get; set; }
        public Clams Clams { get; set; }

        public List<string> toppings = new List<string>();
        //public void Prepare()
        //{
        //    Console.WriteLine("Preparing " + Name);
        //    Console.WriteLine("Tossing dough...");
        //    Console.WriteLine("Adding sauce...");
        //    Console.WriteLine("Adding toppings: ");
        //    for (int i = 0; i < toppings.Count; i++)
        //    {
        //        Console.WriteLine(" " + toppings[i]);
        //    }
        //}

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
