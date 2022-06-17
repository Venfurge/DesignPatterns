using Facade.interfaces;

namespace Facade.models
{
    internal class PizzaPreparingFacade
    {
        private CuttingTable _cuttingTable;
        private BoxingTable _boxingTable;
        private ICuttingStrategy _cuttingStrategy;
        private IBoxingStrategy _boxingStrategy;

        public PizzaPreparingFacade(ICuttingStrategy cuttingStrategy, IBoxingStrategy boxingStrategy)
        {
            _cuttingStrategy = cuttingStrategy;
            _boxingStrategy = boxingStrategy;

            _cuttingTable = new CuttingTable(_cuttingStrategy);
            _boxingTable = new BoxingTable(_boxingStrategy);
        }

        public void Prepare(IPizza pizza)
        {
            Oven.Bake(pizza);
            _cuttingTable.Cut(pizza);
            _boxingTable.Box(pizza);

            if (pizza.isCutted && pizza.isBoxed)
            {
                Console.WriteLine($"{pizza.Name} pizza is prepared");
            }
            else
            {
                Console.WriteLine("Something went wrong!...");
            }
        }

        public void setCuttingStrategy(ICuttingStrategy strategy)
        {
            _cuttingStrategy = strategy;
            _cuttingTable.setCuttingMethod(_cuttingStrategy);
        }

        public void setBoxingStrategy(IBoxingStrategy strategy)
        {
            _boxingStrategy = strategy;
            _boxingTable.setBoxingMethod(_boxingStrategy);
        }
    }
}
