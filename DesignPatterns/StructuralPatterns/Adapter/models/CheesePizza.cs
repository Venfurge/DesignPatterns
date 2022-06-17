using Adapter.interfaces;

namespace Adapter.models
{
    internal class CheesePizza : IPizza
    {
        public string Name { get; set; }

        public CheesePizza(string name)
            => (Name) = (name);

        public void Bake()
        {
            Console.WriteLine($"{Name} pizza is baking...");
        }

        public void Cut()
        {
            Console.WriteLine($"{Name} pizza is cutting by diagonals...");
        }

        public void Box()
        {
            Console.WriteLine($"{Name} pizza boxed");
        }
    }
}
