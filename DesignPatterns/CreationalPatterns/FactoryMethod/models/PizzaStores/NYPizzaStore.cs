using FactoryMethod.enums;
using FactoryMethod.interfaces;
using FactoryMethod.models.NYPizza;

namespace FactoryMethod.models.PizzaStores
{
    internal class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(PizzaType PizzaType)
        {
            return PizzaType switch
            {
                PizzaType.Cheese => new NYCheesePizza(),
                PizzaType.Diablo => new NYDiabloPizza(),
                PizzaType.Cezario => new NYCezarioPizza(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
