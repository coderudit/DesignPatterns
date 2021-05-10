using System;

namespace _001_StrategyPattern
{
    public class FlyRight: IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("FlyRight.Fly");
        }
    }
}