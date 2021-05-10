using System;

namespace _003_DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage espressoBeverage = new Espresso();
            espressoBeverage = new Caramel(espressoBeverage);
            var cost = espressoBeverage.GetCost();
        }
    }
}
