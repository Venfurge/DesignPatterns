using Composite.interfaces;

namespace Composite.models
{
    internal class Menu : IMenu
    {
        public string Name { get; set; }
        public List<IMenu> Children { get; set; }

        public Menu(string name, List<IMenu> children)
            => (Name, Children) = (name, children);

        public double GetPrice()
        {
            return Children.Sum(child => child.GetPrice());
        }

        public void PrintMenu()
        {
            Console.WriteLine($"Menu: {Name}");
            Children.ForEach(child => child.PrintMenu());
            Console.WriteLine("-------------------------------------------");
        }

        public void AddMenuChild(IMenu child)
        {
            Children.Add(child);
        }

        public void RemoveMenuChild(IMenu child)
        {
            Children.Remove(child);
        }
    }
}
