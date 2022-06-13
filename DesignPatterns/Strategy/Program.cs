// See https://aka.ms/new-console-template for more information
using Strategy.models;
using Strategy.models.BakeStrategies;
using Strategy.models.PizzaModels;

Pizza pizza = new ChicagoPizza("Double cheese", 1.99);
pizza.Display();

pizza.Bake();
pizza.setBakeStrategy(new OvenBakeStrategy());
pizza.Bake();

pizza = new NYPizza("Bacon", 2.20);
pizza.Display();

pizza.setBakeStrategy(new MicrowaveBakeStrategy());
pizza.Bake();