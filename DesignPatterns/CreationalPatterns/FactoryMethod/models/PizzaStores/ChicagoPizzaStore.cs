using FactoryMethod.enums;
using FactoryMethod.interfaces;
using FactoryMethod.models.ChicagoPizza;

namespace FactoryMethod.models.PizzaStores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType PizzaType)
        {
            return PizzaType switch
            {
                PizzaType.Cheese => new ChicagoCheesePizza(),
                PizzaType.Diablo => new ChicagoDiabloPizza(),
                PizzaType.Cezario => new ChicagoCezarioPizza(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
