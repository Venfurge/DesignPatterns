using Command.interfaces;

namespace Command.models.commands
{
    internal class BoxCommand : ICommand
    {
        private Pizza _pizaa;
        private bool isBoxed = false;

        public BoxCommand(Pizza Pizza)
            => (_pizaa) = (Pizza);

        public void Execute()
        {
            isBoxed = true;
            Console.WriteLine($"{_pizaa.Name} pizza boxed");
        }

        public void Undo() {
            if (isBoxed)
            {
                isBoxed = false;
                Console.WriteLine($"{_pizaa.Name} pizza unboxed");
            }
        }
    }
}
