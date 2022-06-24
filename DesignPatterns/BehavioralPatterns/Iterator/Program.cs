// See https://aka.ms/new-console-template for more information
using Iterator.interfaces;
using Iterator.models;
using Iterator.models.iterators;

PizzaCollection pizzaCollection = new PizzaCollection();
pizzaCollection.AddItem(new ChicagoPizza());
pizzaCollection.AddItem(new NYPizza());
pizzaCollection.AddItem(new WashingtonPizza());
pizzaCollection.AddItem(new ChicagoPizza());

foreach(IPizza pizza in pizzaCollection)
{
    Console.WriteLine($"Pizza: {pizza.Name}");
}

pizzaCollection.ReverseDirection();

foreach (IPizza pizza in pizzaCollection)
{
    Console.WriteLine($"Pizza: {pizza.Name}");
}