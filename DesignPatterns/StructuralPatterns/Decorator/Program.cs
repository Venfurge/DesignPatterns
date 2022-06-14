// See https://aka.ms/new-console-template for more information
using Decorator.interfaces;
using Decorator.models.PizzaModels;
using Decorator.models.PizzaToppingModels;

Pizza pizza = new ClassicPizza();

pizza = new Mozzarella(pizza);
pizza = new Mozzarella(pizza);
pizza = new TomatoSauce(pizza);
pizza = new Salami(pizza);
pizza = new Salami(pizza);
pizza = new Salami(pizza);
pizza = new Bacon(pizza);
pizza = new Bacon(pizza);
pizza = new Bacon(pizza);
pizza = new Bacon(pizza);
pizza = new Bacon(pizza);

Console.WriteLine(pizza.GetPrettieDescription());
Console.WriteLine(pizza.GetPrice());
