using System;

namespace _006_CommandPattern.Appliances
{
    /// <summary>
    /// Receiver class on which actions are performed.
    /// These can be services also.
    /// </summary>
    public class CeilingFan
    {
        public const int HIGH = 3;
        public const int MEDIUM = 2;
        public const int LOW = 1;
        public const int OFF = 0;

        String _location;

        public int Speed { get; set; }
        public CeilingFan(string location)
        {
            _location = location;
            Speed = OFF;
        }

        public void High()
        {
            Speed = HIGH;
        }

        public void Medium()
        {
            Speed = MEDIUM;
        }

        public void Low()
        {
            Speed = LOW;
        }

        public void Off()
        {
            Speed = OFF;
        }
    }
}
