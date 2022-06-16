namespace Command.interfaces
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
