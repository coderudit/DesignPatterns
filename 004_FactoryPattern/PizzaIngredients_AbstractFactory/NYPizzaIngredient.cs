using _004_FactoryPattern.PizzaIngredients;

namespace _004_FactoryPattern.PizzaIngredients_Factory
{
    public class NYPizzaIngredient : IPizzaIngredient
    {
        Cheese IPizzaIngredient.CreateCheese()
        {
            return new CheddarCheese();
        }

        Clams IPizzaIngredient.CreateClams()
        {
            return new NYClams();
        }

        Dough IPizzaIngredient.CreateDough()
        {
            return new ThinCrust();
        }

        Pepperoni IPizzaIngredient.CreatePepperoni()
        {
            return new NYPepperoni();
        }

        Sauce IPizzaIngredient.CreateSauce()
        {
            return new RedSauce();
        }

        Veggies[] IPizzaIngredient.CreateVeggies()
        {
            return new Veggies[] { new Tomato(), new Capsicum(), new Onion() };
        }
    }
}
