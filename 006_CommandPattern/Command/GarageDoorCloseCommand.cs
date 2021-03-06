using _006_CommandPattern.Appliances;

namespace _006_CommandPattern.Command
{
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
