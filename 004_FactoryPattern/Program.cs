using _004_FactoryPattern.PizzaStores_Factory;
using _004_FactoryPattern.PizzaTypes;

namespace _004_FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            PizzaStore nyPizzaStore = new NYPizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            nyPizzaStore.OrderPizza(PizzaType.Cheese);
            chicagoPizzaStore.OrderPizza(PizzaType.Cheese);
        }
    }
}
