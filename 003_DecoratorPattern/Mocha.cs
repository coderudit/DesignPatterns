namespace _003_DecoratorPattern
{
    public class Mocha: CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override Beverage Beverage { get; set; }

        public override double GetCost()
        {
            return this.Beverage.GetCost() + 0.60;
        }

        public override string GetDescription()
        {
            return this.Beverage + " Mocha added.";
        }
    }
}
