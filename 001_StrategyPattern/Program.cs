using System;

namespace _001_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlyBehaviour flyBehaviourLeft = new FlyLeft();
            IFlyBehaviour flyBehaviourrRight = new FlyRight();

            IQuackBehaviour quackBehaviourSoft = new QuackSoft();
            IQuackBehaviour quackBehaviourLoud = new QuackLoud();

            Duck duck1 = new DuckA(flyBehaviourLeft, quackBehaviourSoft);
            Duck duck2 = new DuckA(flyBehaviourLeft, quackBehaviourLoud);
            Duck duck3 = new DuckB(flyBehaviourrRight, quackBehaviourSoft);
            Duck duck4 = new DuckB(flyBehaviourrRight, quackBehaviourLoud);

            duck1.Swim();
            duck1.DuckFly();
            duck1.DuckQuack();
            Console.WriteLine();

            duck2.DuckFly();
            duck2.DuckQuack();
            duck2.Swim();
            Console.WriteLine();

            duck3.Swim();
            duck3.DuckFly();
            duck3.DuckQuack();
            Console.WriteLine();

            duck4.Swim();
            duck4.DuckFly();
            duck4.DuckQuack();
        }
    }
}
