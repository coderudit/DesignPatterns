using System.Collections.Generic;

namespace _006_CommandPattern.Command
{
    /// <summary>
    /// Macro command which when Invoked calls an action on the array
    /// of receiver classes i.e. Ceiling Fan, Garage Door, Light
    /// </summary>
    public class MacroCommand : ICommand
    {
        ICommand[] _commands;
        Stack<ICommand> _prevCommands = new Stack<ICommand>();
        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }
        public void Execute()
        {
            for (int index = 0; index < _commands.Length; index++)
            {
                _commands[index].Execute();
                _prevCommands.Push(_commands[index]);
            }
        }

        public void Undo()
        {
            while (_prevCommands.Count > 0)
                _prevCommands.Pop().Undo();
        }
    }
}
