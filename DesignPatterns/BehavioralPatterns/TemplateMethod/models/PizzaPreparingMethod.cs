using TemplateMethod.interfaces;

namespace TemplateMethod.models
{
    internal class PizzaPreparingMethod : PreparingMethod
    {
        protected override void Bake(IMeal meal)
        {
            Console.WriteLine($"Baking {meal.Name} with pizza settings...");
        }

        protected override void Cut(IMeal meal)
        {
            Console.WriteLine($"Cutting {meal.Name} by diagonal pattern...");
        }
    }
}
