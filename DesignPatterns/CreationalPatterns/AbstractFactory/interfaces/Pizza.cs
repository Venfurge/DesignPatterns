using AbstractFactory.interfaces.ingredients;

namespace AbstractFactory.interfaces
{
    internal abstract class Pizza
    {
        public abstract ISauce? Sauce { get; set; }
        public abstract IDought? Dought { get; set; }
        public abstract ICheese? Cheese { get; set; }
        public abstract ISalami? Salami { get; set; }

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Pizza is baking...");
        }

        public void Cut()
        {
            Console.WriteLine("Pizza is cutting...");
        }

        public void Box()
        {
            Console.WriteLine("Pizza is boxing...");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Pizza | " +
                $"Sauce: {Sauce?.Name ?? "No sauce"}," +
                $"Dought: {Dought?.Name ?? "No dought"}," +
                $"Cheese: {Cheese?.Name ?? "No cheese"}," +
                $"Salami: {Salami?.Name ?? "No salami"}");
        }
    }
}
