using Flyweight.interfaces;

namespace Flyweight.models.Pizza
{
    internal class PepperoniPizza : IPizza
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string MeatType { get; set; }

        public PepperoniPizza(double price, string name, string description, string imageUrl, string meatType)
            => (Price, Name, Description, ImageUrl, MeatType) = (price, name, description, imageUrl, meatType);
    }
}
