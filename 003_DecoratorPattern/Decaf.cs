namespace _003_DecoratorPattern
{
    public class Decaf: Beverage
    {
        public override string GetDescription()
        {
            return "I am Decaf.";
        }

        public override double GetCost()
        {
            return 2;
        }
    }
}
