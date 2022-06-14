// See https://aka.ms/new-console-template for more information
using Decorator.interfaces;
using Decorator.models.PizzaModels;
using Decorator.models.PizzaToppingModels;

IPizza pizza = new ClassicPizza();

pizza = new Mocarella(pizza);
pizza = new Mocarella(pizza);
pizza = new TomatoSauce(pizza);
pizza = new Salami(pizza);

Console.WriteLine(pizza.getDescription());
Console.WriteLine(pizza.getPrice());
