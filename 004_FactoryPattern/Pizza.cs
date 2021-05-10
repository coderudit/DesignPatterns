using System;
using System.Collections.Generic;

namespace _004_FactoryPattern
{
    public abstract class Pizza
    {
        public string Name;
        public string Dough;
        public string Sauce;
        public List<string> toppings = new List<string>();
        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine(" " + toppings[i]);
            }
        }
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
