using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class TomatoSauce : IPizzaToppingDecorator
    {
        public IPizza Pizza { get; set; }
        public string Description { get; set; } = "Tomato sauce";
        public double Price { get; set; } = 0.2;

        public TomatoSauce(IPizza pizza)
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
