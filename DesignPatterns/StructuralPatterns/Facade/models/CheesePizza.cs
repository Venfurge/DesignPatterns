using Facade.interfaces;

namespace Facade.models
{
    internal class CheesePizza : IPizza
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isCutted { get; set; } = false;
        public bool isBoxed { get; set; } = false;

        public CheesePizza(string name, double price)
            => (Name, Price) = (name, price);
    }
}
