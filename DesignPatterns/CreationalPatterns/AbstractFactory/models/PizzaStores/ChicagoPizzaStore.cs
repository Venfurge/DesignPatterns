using AbstractFactory.enums;
using AbstractFactory.interfaces;
using AbstractFactory.models.Pizza;
using AbstractFactory.models.PizzaIngredientsFactories;

namespace AbstractFactory.models.PizzaStores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        protected override interfaces.Pizza CreatePizza(PizzaType PizzaType)
        {
            IPizzaIngredientFactory pizzaIngredientFactory
                = new ChicagoPizzaIngredientsFactory();

            return PizzaType switch
            {
                PizzaType.Cezario => new CezarioPizza(pizzaIngredientFactory),
                PizzaType.Cheese => new CheesePizza(pizzaIngredientFactory),
                PizzaType.Diablo => new DiabloPizza(pizzaIngredientFactory),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
