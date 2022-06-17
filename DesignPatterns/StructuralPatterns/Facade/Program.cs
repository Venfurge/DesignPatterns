// See https://aka.ms/new-console-template for more information
using Facade.interfaces;
using Facade.models;
using Facade.models.boxingStrategies;
using Facade.models.cuttingStrategies;

IPizza pizza = new CheesePizza("Mozzarella", 2.99);
PizzaPreparingFacade pizzaFacade = new PizzaPreparingFacade(
    new SquareCutStrategy(),
    new SquareBoxStrategy());

pizzaFacade.Prepare(pizza);

pizzaFacade.setBoxingStrategy(new CircleBoxStrategy());
pizzaFacade.Prepare(pizza);