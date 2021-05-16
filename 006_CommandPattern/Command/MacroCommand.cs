using System;
using System.Collections.Generic;

namespace _006_CommandPattern.Command
{
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
