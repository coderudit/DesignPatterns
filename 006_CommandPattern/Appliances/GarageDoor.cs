using System;

namespace _006_CommandPattern.Appliances
{
    /// <summary>
    /// Receiver class on which actions are performed.
    /// These can be services also.
    /// </summary>
    public class GarageDoor
    {
        public void Up()
        {
            Console.WriteLine("Garage Door up.");
        }
        public void Down()
        {
            Console.WriteLine("Garage Door down.");
        }

        public void Stop()
        {
            Console.WriteLine("Garage Door stop.");
        }

        public void LightOn()
        {
            Console.WriteLine("Garage Door Light on.");
        }

        public void LightOff()
        {
            Console.WriteLine("Garage Door Light off.");
        }
    }
}
