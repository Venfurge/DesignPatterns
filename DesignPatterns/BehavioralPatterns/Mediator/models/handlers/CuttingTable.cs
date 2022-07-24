using Mediator.interfaces;

namespace Mediator.models.handlers
{
    internal class CuttingTable : Handler
    {
        public void CutPizza(Pizza pizza)
        {
            pizza.IsCutted = true;
            mediator?.Notify(this, "CutPizzaEvent");
        }
    }
}
