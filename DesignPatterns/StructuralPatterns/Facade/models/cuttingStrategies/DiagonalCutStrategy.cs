using Facade.interfaces;

namespace Facade.models.cuttingStrategies
{
    internal class DiagonalCutStrategy : ICuttingStrategy
    {
        public IPizza Cut(IPizza Pizza)
        {
            Console.WriteLine($"{Pizza.Name} is cutting by diagonal pattern...");
            Pizza.isCutted = true;
            return Pizza;
        }
    }
}
