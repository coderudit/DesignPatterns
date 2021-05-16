namespace _006_CommandPattern.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}
