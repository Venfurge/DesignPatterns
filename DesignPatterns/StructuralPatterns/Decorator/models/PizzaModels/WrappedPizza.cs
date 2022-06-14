using Decorator.interfaces;

namespace Decorator.models.PizzaModels
{
    internal class WrappedPizza : IPizza
    {
        public string Description { get; set; } = "Wrapped pizza";
        public double Price { get; set; } = 0.99;

        public double getPrice()
        {
            return Price;
        }

        public string getDescription()
        {
            return Description;
        }
    }
}
