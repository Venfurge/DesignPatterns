using Flyweight.interfaces;

namespace Flyweight.models.Pizza
{
    internal class CheesePizza : IPizza
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CheeseType { get; set; }

        public CheesePizza(double price, string name, string description, string imageUrl, string cheeseType)
            => (Price, Name, Description, ImageUrl, CheeseType) = (price, name, description, imageUrl, cheeseType);
    }
}
