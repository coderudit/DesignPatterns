using System;
using System.Collections.Generic;
using System.Text;

namespace _004_FactoryPattern
{
    public class NYIndianPizza: Pizza
    {
        public NYIndianPizza()
        {
            Name = "NY Style India Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }

    public class ChicagoIndianPizza : Pizza
    {
        public ChicagoIndianPizza()
        {
            Name = "Chicago Style Indian Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
