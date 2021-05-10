namespace _004_FactoryPattern
{
    public class NYMexicanPizza: Pizza
    {
        public NYMexicanPizza()
        {
            Name = "NY Style Mexican Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
    public class ChicagoMexicanPizza : Pizza
    {
        public ChicagoMexicanPizza()
        {
            Name = "Chicago Style Mexican Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
