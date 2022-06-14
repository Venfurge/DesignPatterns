using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class Bacon : IPizzaToppingDecorator
    {
        public IPizza Pizza { get; set; }
        public string Description { get; set; } = "Bacon";
        public double Price { get; set; } = 0.8;

        public Bacon(IPizza pizza)
            => (Pizza) = (pizza);

        public double getPrice()
        {
            return Pizza.getPrice() + Price;
        }

        public string getDescription()
        {
            return $"{Pizza.getDescription()}, {Description}";
        }
    }
}
