using _006_CommandPattern.Appliances;

namespace _006_CommandPattern.Command
{
    /// <summary>
    /// Individual command which when Invoked calls an action on 
    /// the receiver class i.e. Garage Door
    /// </summary>
    public class GarageDoorOpenCommand : ICommand
    {
        GarageDoor _garageDoor;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Up();
        }
        public void Undo()
        {
            _garageDoor.Down();
        }
    }
}
