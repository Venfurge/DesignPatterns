using Decorator.interfaces;

namespace Decorator.models.PizzaModels
{
    internal class ClassicPizza : IPizza
    {
        public string Description { get; set; } = "Basic pizza";
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
