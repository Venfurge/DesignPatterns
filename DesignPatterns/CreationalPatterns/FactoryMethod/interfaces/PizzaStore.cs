using FactoryMethod.enums;
using FactoryMethod.interfaces;

namespace FactoryMethod.models
{
    internal abstract class PizzaStore
    {
        public void OrderPizza(PizzaType PizzaType)
        {
            Pizza pizza = CreatePizza(PizzaType);

            pizza.DisplayDeatails();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract Pizza CreatePizza(PizzaType PizzaType);
    }
}
