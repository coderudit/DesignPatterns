namespace _004_FactoryPattern
{
    public class NYMarghereitaPizza: Pizza
    {
        public NYMarghereitaPizza()
        {
            Name = "NY Style Marghereita Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
        }
    }

    public class ChicagoMarghereitaPizza : Pizza
    {
        public ChicagoMarghereitaPizza()
        {
            Name = "Chicago Marghereita Pizza";
            Dough = "Thin Crust Dough";
            Sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");

        }
    }
}
