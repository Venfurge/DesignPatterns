using AbstractFactory.interfaces.ingredients;

namespace AbstractFactory.interfaces
{
    internal interface IPizzaIngredientFactory
    {
        public ISauce CreateSauce();
        public IDought CreateDought();
        public ICheese CreateCheese();
        public ISalami CreateSalami();
    }
}
