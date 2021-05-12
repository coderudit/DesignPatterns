using _004_FactoryPattern.PizzaTypes;

namespace _004_FactoryPattern.PizzaStores_Factory
{
    public abstract class PizzaStore
    {
        /// <summary>
        /// Factory method
        /// </summary>
        /// <param name="pizzaType"></param>
        /// <returns></returns>
        protected abstract Pizza CreatePizza(PizzaType pizzaType);

        public Pizza OrderPizza(PizzaType pizzaType)
        {
            Pizza pizza = CreatePizza(pizzaType);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}
