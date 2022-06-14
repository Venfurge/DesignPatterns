using Decorator.interfaces;

namespace Decorator.models.PizzaModels
{
    internal class WrappedPizza : Pizza
    {
        public override string Description { get; set; } = "Wrapped pizza";
        public override double Price { get; set; } = 0.99;
    }
}
