using Adapter.interfaces;

namespace Adapter.models
{
    internal class BerryPie : IPie
    {
        public string Name { get; set; }

        public BerryPie(string name)
            => (Name) = (name);

        public void Bake()
        {
            Console.WriteLine($"{Name} pie is baking...");
        }

        public void Box()
        {
            Console.WriteLine($"{Name} pie boxed.");
        }
    }
}
