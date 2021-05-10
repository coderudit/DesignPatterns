using System;

namespace _001_StrategyPattern
{
    public class DuckB : Duck
    {
        public DuckB(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Duck B");
        }
    }
}
