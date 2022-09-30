using System.Collections.Generic;
using _006_CommandPattern.Command;

namespace _006_CommandPattern
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class RemoteControl
    {
        IList<ICommand> _commandOnList;
        IList<ICommand> _commandOffList;
        ICommand _undoCommand;
        public RemoteControl(IList<ICommand> commandOnList, IList<ICommand> commandOffList)
        {
            _commandOnList = commandOnList;
            _commandOffList = commandOffList;
        }

        public void ButtonOnPressed(int slot)
        {
            _commandOnList[slot].Execute();
            _undoCommand= _commandOnList[slot];
        }

        public void ButtonOffPressed(int slot)
        {
            _commandOffList[slot].Execute();
            _undoCommand = _commandOffList[slot];
        }

        public void UndoButtonPressed()
        {
            _undoCommand.Undo();
        }
    }
}
