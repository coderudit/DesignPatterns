using System;

namespace _006_CommandPattern.Appliances
{
    /// <summary>
    /// Receiver class on which actions are performed.
    /// These can be services also.
    /// </summary>
    public class Light
    {
        public void On()
        {
            Console.WriteLine("Light on.");
        }

        public void Off()
        {
            Console.WriteLine("Light off.");
        }
    }
}
