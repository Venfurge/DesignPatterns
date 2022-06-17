using Facade.interfaces;

namespace Facade.models.boxingStrategies
{
    internal class CircleBoxStrategy : IBoxingStrategy
    {
        public IPizza Box(IPizza Pizza)
        {
            Console.WriteLine($"{Pizza.Name} is boxing to circle box...");
            Pizza.isBoxed = true;
            return Pizza;
        }
    }
}
