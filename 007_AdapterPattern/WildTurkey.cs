using System;

namespace _007_AdapterPattern
{
    public class WildTurkey : ITurkey
    {
        public void Gobble()
        {
            Console.WriteLine("Gobble");
        }

        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }
}
