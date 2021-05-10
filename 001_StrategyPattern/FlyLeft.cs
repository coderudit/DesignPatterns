using System;

namespace _001_StrategyPattern
{
    public class FlyLeft: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("FlyLeft.Fly");
        }
    }
}