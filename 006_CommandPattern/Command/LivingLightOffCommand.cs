using _006_CommandPattern.Appliances;

namespace _006_CommandPattern.Command
{
    public class LivingLightOffCommand : ICommand
    {
        Light _light;

        public LivingLightOffCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.Off();
        }

        public void Undo()
        {
            _light.On();
        }
    }
}
