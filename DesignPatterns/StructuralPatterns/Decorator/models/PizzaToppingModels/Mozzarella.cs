using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class Mozzarella : IPizzaToppingDecorator
    {
        public IPizza Pizza { get; set; }
        public string Description { get; set; } = "Mozzarella cheese";
        public double Price { get; set; } = 0.4;

        public Mozzarella(IPizza pizza) 
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
