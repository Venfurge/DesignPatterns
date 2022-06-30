using Composite.interfaces;

namespace Composite.models
{
    internal class Pizza : IMenu
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Pizza(string name, string description, double price)
            => (Name, Description, Price) = (name, description, price);

        public double GetPrice()
        {
            return Price;
        }

        public void PrintMenu()
        {
            Console.WriteLine($"Pizza: {Name} | {Description} | ${Price}");
        }
    }
}
