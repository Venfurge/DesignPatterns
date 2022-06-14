using Decorator.interfaces;

namespace Decorator.models.PizzaModels
{
    internal class GrilledPizza : Pizza
    {
        public override string Description { get; set; } = "Grilled pizza";
        public override double Price { get; set; } = 0.99;
    }
}
