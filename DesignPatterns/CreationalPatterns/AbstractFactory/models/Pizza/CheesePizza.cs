using AbstractFactory.interfaces;
using AbstractFactory.interfaces.ingredients;

namespace AbstractFactory.models.Pizza
{
    internal class CheesePizza : interfaces.Pizza
    {
        public override ISauce? Sauce { get; set; }
        public override IDought? Dought { get; set; }
        public override ICheese? Cheese { get; set; }
        public override ISalami? Salami { get; set; }


        private IPizzaIngredientFactory _pizzaIngredientFactory;

        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory)
            => (_pizzaIngredientFactory) = (pizzaIngredientFactory);

        public override void Prepare()
        {
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Dought = _pizzaIngredientFactory.CreateDought();
            Cheese = _pizzaIngredientFactory.CreateCheese();
            Salami = _pizzaIngredientFactory.CreateSalami();
        }
    }
}
