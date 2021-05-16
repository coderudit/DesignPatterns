using System;
using System.Collections.Generic;
using _006_CommandPattern.Appliances;
using _006_CommandPattern.Command;

namespace _006_CommandPattern
{
    public class RemoteLoader
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            GarageDoor garage = new GarageDoor();
            ICommand lightOnCommand = new LivingLightOnCommand(light);
            ICommand lightOffCommand = new LivingLightOffCommand(light);
            ICommand garageOpenCommand = new GarageDoorOpenCommand(garage);
            ICommand garageCloseCommand = new GarageDoorCloseCommand(garage);

            ICommand[] macroOnCommands = { lightOnCommand, garageOpenCommand };
            ICommand[] macroOffCommands = { lightOffCommand, garageCloseCommand };
            var macroOn = new MacroCommand(macroOnCommands);
            var macroOff = new MacroCommand(macroOffCommands);

            IList<ICommand> onCommands = new List<ICommand> { lightOnCommand, garageOpenCommand, macroOn };
            IList<ICommand> offCommands = new List<ICommand> { lightOffCommand, garageCloseCommand, macroOff };
            var remoteControl = new RemoteControl(onCommands, offCommands);
            
            remoteControl.ButtonOnPressed(1);
            remoteControl.ButtonOnPressed(3);
        }
    }
}
