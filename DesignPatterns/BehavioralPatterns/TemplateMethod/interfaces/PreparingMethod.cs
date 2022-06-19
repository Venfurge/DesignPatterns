namespace TemplateMethod.interfaces
{
    internal abstract class PreparingMethod
    {
        public void Prepare(IMeal meal)
        {
            Bake(meal);
            Cut(meal);
            Box(meal);
            Console.WriteLine($"{meal.Name} successfully prepared");
        }

        protected virtual void Bake(IMeal meal)
        {
            Console.WriteLine($"Baking {meal.Name}...");
        }

        protected virtual void Cut(IMeal meal)
        {
            Console.WriteLine($"Cutting {meal.Name}...");
        }

        protected void Box(IMeal meal)
        {
            Console.WriteLine($"Boxing {meal.Name}...");
        }
    }
}
