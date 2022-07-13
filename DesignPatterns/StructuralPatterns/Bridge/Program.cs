// See https://aka.ms/new-console-template for more information
using Bridge.interfaces;
using Bridge.models.Additions;
using Bridge.models.Pizza;

List<IAdditions> additions = new List<IAdditions>();
additions.Add(new TomatoSauce());
additions.Add(new Mozzarella());
IPizza pizza = new NYPizza(additions);

additions = new List<IAdditions>();
additions.Add(new TomatoSauce());
additions.Add(new Mozzarella());
additions.Add(new Gorgonzolla());
IPizza secondPizza = new ChicagoPizza(additions);

Console.WriteLine($"First pizza price: {pizza.Price()}");
Console.WriteLine($"Second pizza price: {secondPizza.Price()}");