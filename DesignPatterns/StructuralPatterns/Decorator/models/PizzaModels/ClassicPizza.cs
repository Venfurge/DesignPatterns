using Decorator.interfaces;

namespace Decorator.models.PizzaModels
{
    internal class ClassicPizza : Pizza
    {
        public override string Description { get; set; } = "Basic pizza";
        public override double Price { get; set; } = 0.99;
    }
}
