using Flyweight.interfaces;

namespace Flyweight.models.Pizza
{
    internal class PineapplePizza : IPizza
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool IsCanPineapple { get; set; }

        public PineapplePizza(double price, string name, string description, string imageUrl, bool isCanPineapple)
            => (Price, Name, Description, ImageUrl, IsCanPineapple) = (price, name, description, imageUrl, isCanPineapple);
    }
}
