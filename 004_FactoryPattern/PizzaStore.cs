namespace _004_FactoryPattern
{
    public abstract class PizzaStore
    {
        public PizzaStore()
        {
        }

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
