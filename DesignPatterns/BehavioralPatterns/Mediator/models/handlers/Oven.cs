using Mediator.interfaces;

namespace Mediator.models.handlers
{
    internal class Oven : Handler
    {
        public void BakePizza(Pizza pizza)
        {
            pizza.IsBaked = true;
            mediator?.Notify(this, "BakePizzaEvent");
        }
    }
}
