using _006_CommandPattern.Appliances;

namespace _006_CommandPattern.Command
{
    public class CeilingFanHighCommand : ICommand
    {
        CeilingFan _ceilingFan;
        int _prevSpeed;
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            _prevSpeed = _ceilingFan.Speed;
            _ceilingFan.High();
        }
        public void Undo()
        {
            if (_prevSpeed == CeilingFan.HIGH)
                _ceilingFan.High();
            else if (_prevSpeed == CeilingFan.MEDIUM)
                _ceilingFan.Medium();
            else if (_prevSpeed == CeilingFan.LOW)
                _ceilingFan.Low();
            else if (_prevSpeed == CeilingFan.OFF)
                _ceilingFan.Off();
        }
    }
}
