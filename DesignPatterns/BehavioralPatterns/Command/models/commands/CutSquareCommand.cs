using Command.interfaces;

namespace Command.models.commands
{
    internal class CutSquareCommand : ICommand
    {
        private Pizza _pizaa;

        public CutSquareCommand(Pizza Pizza)
            => (_pizaa) = (Pizza);

        public void Execute()
        {
            Console.WriteLine($"{_pizaa.Name} pizza cutted into squares");
        }
        public void Undo() { }
    }
}
