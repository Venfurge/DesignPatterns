// See https://aka.ms/new-console-template for more information
using Prototype.models;

Pizza onePizza = new Pizza("Cheese", "A lot of mozzarella cheese", 3.99);
onePizza.Print();

Console.WriteLine("Cloned Pizza");

Pizza clonedPizza = onePizza.ShallowCopy();
clonedPizza.Print();