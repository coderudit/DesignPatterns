namespace _006_CommandPattern.Command
{
    /// <summary>
    /// Interface representing commands that can be executed.
    /// These can be Create, Get, Update or Delete commands.
    /// </summary>
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
