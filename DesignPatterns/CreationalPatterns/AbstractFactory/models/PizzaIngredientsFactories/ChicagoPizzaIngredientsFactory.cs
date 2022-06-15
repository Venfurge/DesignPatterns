using AbstractFactory.interfaces;
using AbstractFactory.interfaces.ingredients;
using AbstractFactory.models.Cheese;
using AbstractFactory.models.Dought;
using AbstractFactory.models.Salami;
using AbstractFactory.models.Sauce;

namespace AbstractFactory.models.PizzaIngredientsFactories
{
    internal class ChicagoPizzaIngredientsFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new Mozzarella();
        }

        public IDought CreateDought()
        {
            return new RoughtDought();
        }

        public ISalami CreateSalami()
        {
            return new Chorizo();
        }

        public ISauce CreateSauce()
        {
            return new TomatoSauce();
        }
    }
}
