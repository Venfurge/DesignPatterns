using Command.interfaces;

namespace Command.models.commands
{
    internal class NoCommand : ICommand
    {
        public void Execute() { }
        public void Undo() { }
    }
}
