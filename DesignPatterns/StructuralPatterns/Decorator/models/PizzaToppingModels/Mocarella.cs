using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class Mocarella : IPizzaToppingDecorator
    {
        public IPizza Pizza { get; set; }
        public string Description { get; set; } = "Mocarella cheese";
        public double Price { get; set; } = 0.4;

        public Mocarella(IPizza pizza) 
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
