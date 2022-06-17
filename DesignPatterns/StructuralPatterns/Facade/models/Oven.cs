using Facade.interfaces;

namespace Facade.models
{
    internal static class Oven
    {
        public static IPizza Bake(IPizza Pizza)
        {
            Console.WriteLine($"{Pizza.Name} pizza is baking...");
            return Pizza;
        }
    }
}
