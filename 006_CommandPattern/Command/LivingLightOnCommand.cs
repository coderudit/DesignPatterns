using _006_CommandPattern.Appliances;

namespace _006_CommandPattern.Command
{
    public class LivingLightOnCommand : ICommand
    {
        Light _light;
        
        public LivingLightOnCommand(Light light)
        {
            _light = light;
        }
        public void Execute()
        {
            _light.On();
        }
        public void Undo()
        {
            _light.Off();
        }
    }
}
