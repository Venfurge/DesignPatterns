using Mediator.interfaces;
using Mediator.models.handlers;

namespace Mediator.models
{
    internal class PizzaStore : IMediator
    {
        private Oven _oven;
        private CuttingTable _cuttingTable;
        private BoxingTable _boxingTable;

        public PizzaStore(Oven oven, CuttingTable cuttingTable, BoxingTable boxingTable)
        {
            _oven = oven;
            _oven.SetMediator(this);
            _cuttingTable = cuttingTable;
            _cuttingTable.SetMediator(this);
            _boxingTable = boxingTable;
            _boxingTable.SetMediator(this);
        }

        public void Notify(object sender, string type)
        {
            var notifyString = type switch
            {
                "BakePizzaEvent" => "Pizza is baked",
                "CutPizzaEvent" => "Pizza is cutted",
                "BoxPizzaEvent" => "Pizza is boxed",
                _ => "Mediator unknown type",
            };

            Console.WriteLine(notifyString);
        }
    }
}
