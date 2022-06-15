using AbstractFactory.enums;

namespace AbstractFactory.interfaces
{
    internal abstract class PizzaStore
    {
        public void OrderPizza(PizzaType PizzaType)
        {
            Pizza pizza = CreatePizza(PizzaType);

            pizza.Prepare();
            pizza.DisplayDetails();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract Pizza CreatePizza(PizzaType PizzaType);
    }
}
