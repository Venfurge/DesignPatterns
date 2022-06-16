using Command.interfaces;

namespace Command.models.commands
{
    internal class CutDiagonalCommand : ICommand
    {
        private Pizza _pizaa;

        public CutDiagonalCommand(Pizza Pizza)
            => (_pizaa) = (Pizza);

        public void Execute()
        {
            Console.WriteLine($"{_pizaa.Name} pizza cutted by diagonals");
        }
        public void Undo() { }
    }
}
