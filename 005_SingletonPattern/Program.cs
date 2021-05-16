using System;

namespace _005_SingletonPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = ChocolateBoiler.GetChocolateBoiler();
            var instance2 = ChocolateBoiler.GetChocolateBoiler();
            if(instance1 == instance2)
            {
                Console.WriteLine("Same instances.");
            }
            else
            {
                Console.WriteLine("Different instances.");
            }
        }
    }
}
