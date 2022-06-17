using Facade.interfaces;

namespace Facade.models.boxingStrategies
{
    internal class SquareBoxStrategy : IBoxingStrategy
    {
        public IPizza Box(IPizza Pizza)
        {
            Console.WriteLine($"{Pizza.Name} is boxing to square box...");
            Pizza.isBoxed = true;
            return Pizza;
        }
    }
}
