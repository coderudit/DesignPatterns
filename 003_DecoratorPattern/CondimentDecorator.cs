namespace _003_DecoratorPattern
{
    public abstract class CondimentDecorator: Beverage
    {
        public abstract Beverage Beverage { get; set; }
    }
}
