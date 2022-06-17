using Facade.interfaces;

namespace Facade.models.cuttingStrategies
{
    internal class SquareCutStrategy : ICuttingStrategy
    {
        public IPizza Cut(IPizza Pizza)
        {
            Console.WriteLine($"{Pizza.Name} is cutting to square pieces...");
            Pizza.isCutted = true;
            return Pizza;
        }
    }
}
