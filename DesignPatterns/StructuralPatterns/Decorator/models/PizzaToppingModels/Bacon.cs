using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class Bacon : PizzaToppingDecorator
    {
        public override Pizza Pizza { get; set; }
        public override string Description { get; set; } = "Bacon";
        public override double Price { get; set; } = 0.8;

        public Bacon(Pizza pizza)
            => (Pizza) = (pizza);
    }
}
