using Facade.interfaces;

namespace Facade.models
{
    internal class CuttingTable
    {
        private ICuttingStrategy _cuttingStrategy;

        public CuttingTable(ICuttingStrategy strategy)
            => (_cuttingStrategy) = (strategy);

        public IPizza Cut(IPizza Pizza)
        {
            _cuttingStrategy.Cut(Pizza);
            return Pizza;
        }

        public void setCuttingMethod(ICuttingStrategy Strategy)
        {
            _cuttingStrategy = Strategy;
        }
    }
}
