using Decorator.interfaces;

namespace Decorator.models.PizzaToppingModels
{
    internal class TomatoSauce : PizzaToppingDecorator
    {
        public override Pizza Pizza { get; set; }
        public override string Description { get; set; } = "TomatoSauce";
        public override double Price { get; set; } = 0.2;

        public TomatoSauce(Pizza pizza)
            => (Pizza) = (pizza);
    }
}
