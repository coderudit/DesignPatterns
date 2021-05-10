namespace _003_DecoratorPattern
{
    public class Espresso: Beverage
    {
        public override string GetDescription()
        {
            return "I am an Espresso";
        }

        public override double GetCost()
        {
            return 1.5;
        }
    }
}
