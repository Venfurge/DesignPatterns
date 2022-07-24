using Mediator.interfaces;

namespace Mediator.models.handlers
{
    internal class BoxingTable : Handler
    {
        public void BoxPizza(Pizza pizza)
        {
            pizza.IsBoxed = true;
            mediator?.Notify(this, "BoxPizzaEvent");
        }
    }
}
