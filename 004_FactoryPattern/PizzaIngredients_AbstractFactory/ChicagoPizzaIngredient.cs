using System;
using System.Collections.Generic;
using System.Text;
using _004_FactoryPattern.PizzaIngredients;

namespace _004_FactoryPattern.PizzaIngredients_Factory
{
    class ChicagoPizzaIngredient: IPizzaIngredient
    {
        Cheese IPizzaIngredient.CreateCheese()
        {
            return new MozarellaCheese();
        }

        Clams IPizzaIngredient.CreateClams()
        {
            return new ChicagoClams();
        }

        Dough IPizzaIngredient.CreateDough()
        {
            return new ThickCrust();
        }

        Pepperoni IPizzaIngredient.CreatePepperoni()
        {
            return new ChicagoPepperoni();
        }

        Sauce IPizzaIngredient.CreateSauce()
        {
            return new GreenSauce();
        }

        Veggies[] IPizzaIngredient.CreateVeggies()
        {
            return new Veggies[] { new Capsicum(), new Onion(), new Olive(), new Jalaepeno() };
        }
    }
}
