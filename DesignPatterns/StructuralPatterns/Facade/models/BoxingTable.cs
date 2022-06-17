using Facade.interfaces;

namespace Facade.models
{
    internal class BoxingTable
    {
        private IBoxingStrategy _boxingStrategy;

        public BoxingTable(IBoxingStrategy strategy)
            => (_boxingStrategy) = (strategy);

        public IPizza Box(IPizza Pizza)
        {
            _boxingStrategy.Box(Pizza);
            return Pizza;
        }

        public void setBoxingMethod(IBoxingStrategy Strategy)
        {
            _boxingStrategy = Strategy;
        }
    }
}
