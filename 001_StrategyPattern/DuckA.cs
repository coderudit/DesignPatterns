using System;

namespace _001_StrategyPattern
{
    public class DuckA : Duck
    {
        public DuckA(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour) : base(flyBehaviour, quackBehaviour)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Duck A");
        }
    }
}
