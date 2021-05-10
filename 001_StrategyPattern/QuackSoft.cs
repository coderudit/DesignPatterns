using System;

namespace _001_StrategyPattern
{
    public class QuackSoft: IQuackBehaviour
    {
        public void Quack()
        {
            Console.WriteLine("QuackSoft.Quack");
        }
    }
}