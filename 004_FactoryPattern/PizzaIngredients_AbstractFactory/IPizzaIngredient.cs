using _004_FactoryPattern.PizzaIngredients;

namespace _004_FactoryPattern.PizzaIngredients_Factory
{
    public interface IPizzaIngredient
    {
        internal Cheese CreateCheese();
        internal Clams CreateClams();
        internal Dough CreateDough();
        internal Pepperoni CreatePepperoni();
        internal Veggies[] CreateVeggies();
        internal Sauce CreateSauce();
    }
}
