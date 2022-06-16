using Command.interfaces;

namespace Command.models.commands
{
    internal class BakeCommand : ICommand
    {
        private Pizza _pizaa;

        public BakeCommand(Pizza Pizza) 
            => (_pizaa) = (Pizza);

        public void Execute()
        {
            Console.WriteLine($"{_pizaa.Name} pizza baked");
        }

        public void Undo() { }
    }
}
