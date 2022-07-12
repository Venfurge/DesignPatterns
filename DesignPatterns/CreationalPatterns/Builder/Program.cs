// See https://aka.ms/new-console-template for more information
using Builder.models;

PizzaBuilder pizzaBuilder = new PizzaBuilder();
pizzaBuilder.SetName("Custom pizza");
pizzaBuilder.SetDescription("My own custom pizza");
pizzaBuilder.AddTomatoSauce();
pizzaBuilder.AddPineapple();
pizzaBuilder.AddSalad();

Pizza ownPizza = pizzaBuilder.GetResult();
ownPizza.Print();

pizzaBuilder.SetCezarioPizza();
Pizza cezarioPizza = pizzaBuilder.GetResult();
cezarioPizza.Print();

pizzaBuilder.SetCheesePizza();
Pizza cheesePizza = pizzaBuilder.GetResult();
cheesePizza.Print();

pizzaBuilder.SetBrandPizza();
Pizza brandPizza = pizzaBuilder.GetResult();
brandPizza.Print();