using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class Salami : PizzaToppingDecorator
    {
        public override Pizza Pizza { get; set; }
        public override string Description { get; set; } = "Salami";
        public override double Price { get; set; } = 0.6;

        public Salami(Pizza pizza)
            => (Pizza) = (pizza);
    }
}
