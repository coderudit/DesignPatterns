namespace _003_DecoratorPattern
{
    public class Caramel: CondimentDecorator
    {
        public Caramel(Beverage beverage)
        {
            this.Beverage = beverage;
        }
        public override Beverage Beverage { get; set ; }

        public override double GetCost()
        {
            return this.Beverage.GetCost() +  0.75;
        }

        public override string GetDescription()
        {
            return this.Beverage + " Caramel added.";
        }
    }
}
