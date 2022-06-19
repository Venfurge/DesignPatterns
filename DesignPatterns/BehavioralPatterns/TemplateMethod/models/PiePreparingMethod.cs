using TemplateMethod.interfaces;

namespace TemplateMethod.models
{
    internal class PiePreparingMethod : PreparingMethod
    {
        protected override void Bake(IMeal meal)
        {
            Console.WriteLine($"Baking {meal.Name} with pie settings...");
        }

        protected override void Cut(IMeal meal)
        {
            return;
        }
    }
}
