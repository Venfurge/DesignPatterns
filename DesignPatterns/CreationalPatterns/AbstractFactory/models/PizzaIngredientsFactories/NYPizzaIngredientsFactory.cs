using AbstractFactory.interfaces;
using AbstractFactory.interfaces.ingredients;
using AbstractFactory.models.Cheese;
using AbstractFactory.models.Dought;
using AbstractFactory.models.Salami;
using AbstractFactory.models.Sauce;

namespace AbstractFactory.models.PizzaIngredientsFactories
{
    internal class NYPizzaIngredientsFactory : IPizzaIngredientFactory
    {
        public ICheese CreateCheese()
        {
            return new Granapadano();
        }

        public IDought CreateDought()
        {
            return new ThinCrispyDought();
        }

        public ISalami CreateSalami()
        {
            return new Pepperoni();
        }

        public ISauce CreateSauce()
        {
            return new TomatoSauce();
        }
    }
}
