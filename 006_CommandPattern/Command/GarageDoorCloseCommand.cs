using _006_CommandPattern.Appliances;

namespace _006_CommandPattern.Command
{
    /// <summary>
    /// Individual command which when Invoked calls an action on 
    /// the receiver class i.e. Garage Door
    /// </summary>
    public class GarageDoorCloseCommand : ICommand
    {
        GarageDoor _garageDoor;
        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Down();
        }
        public void Undo()
        {
            _garageDoor.Up();
        }
    }
}
