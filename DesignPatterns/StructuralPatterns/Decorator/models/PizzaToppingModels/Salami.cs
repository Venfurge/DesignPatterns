using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class Salami : IPizzaToppingDecorator
    {
        public IPizza Pizza { get; set; }
        public string Description { get; set; } = "Salami";
        public double Price { get; set; } = 0.6;

        public Salami(IPizza pizza)
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
