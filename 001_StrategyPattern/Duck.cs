using System;

namespace _001_StrategyPattern
{
    /// <summary>
    /// Super class with common behaviour
    /// </summary>
    public abstract class Duck
    {
        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            FlyBehaviour = flyBehaviour;
            QuackBehaviour = quackBehaviour;
        }
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        public void DuckFly()
        {
            Console.WriteLine("Duck.DuckFly");
            FlyBehaviour.Fly();
        }

        public void DuckQuack()
        {
            Console.WriteLine("Duck.DuckQuack");
            QuackBehaviour.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("Duck.Swim");
        }

        /// <summary>
        /// Here Display is not declared inside the Interface because Display is a functionality 
        /// which is going to be different for every other duck, so there won't be no 2 ducks using
        /// the same display.
        /// </summary>
        public abstract void Display();
    }

    
}
