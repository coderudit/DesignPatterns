using _006_CommandPattern.Appliances;

namespace _006_CommandPattern.Command
{
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
