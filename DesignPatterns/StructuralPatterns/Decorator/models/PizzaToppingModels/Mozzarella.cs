using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class Mozzarella : PizzaToppingDecorator
    {
        public override Pizza Pizza { get; set; }
        public override string Description { get; set; } = "Mozzarella";
        public override double Price { get; set; } = 0.4;

        public Mozzarella(Pizza pizza)
            => (Pizza) = (pizza);
    }
}
