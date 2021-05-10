using System;

namespace _001_StrategyPattern
{
    public class QuackLoud: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("QuackLoud.Quack");
        }
    }
}