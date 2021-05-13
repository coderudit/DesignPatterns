namespace _005_SingletonPatterns
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        //Eagerly created chocolate builder
        private static ChocolateBoiler chocolateBoiler = new ChocolateBoiler();
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        //public static ChocolateBoiler GetChocolateBoiler()
        //{
        //    if (chocolateBoiler == null)
        //        chocolateBoiler = new ChocolateBoiler();
        //    return chocolateBoiler;
        //}

        public void Fill()
        {
            // fi ll the boiler with a milk/chocolate mixture
            if (empty)
            {
                empty = false;
                boiled = false;
            }
        }

        public void Drain()
        {
            // drain the boiled milk and chocolate
            if (!empty && boiled)
            {
                empty = true;
            }
        }

        public void Boil()
        {
            // bring the contents to a boil
            if (!empty && !boiled)
            {
                boiled = true;
            }
        }

    }
}
