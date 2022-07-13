// See https://aka.ms/new-console-template for more information
using Flyweight.interfaces;
using Flyweight.models;
using Flyweight.models.Pizza;

List<IPizza> list = new List<IPizza>();
list.Add(new CheesePizza(4.99, "Mozzarella Pizza", "A lot of cheese", "../img/mozzarella_pizza.png", "Mozzarella"));
list.Add(new PepperoniPizza(6.99, "Pepperoni Pizza", "With pepperoni slices", "../img/pepperoni_pizza.png", "Pepperoni"));
list.Add(new PineapplePizza(5.99, "Pineapple Pizza", "Pizza with canned pineapples", "../img/pineapple_pizza.png", true));

FlyweightFactory factory = new FlyweightFactory(list);
factory.PrintFlyweights();

AddPizzaToFactory(factory, new CheesePizza(3.99, "Mozzarella Pizza XS", "Small amount of cheese", "../img/mozzarella_pizza.png", "Mozzarella"));
AddPizzaToFactory(factory, new CheesePizza(3.99, "Pepperoni Pizza XLL", "Small amount of cheese", "../img/mozzarella_pizza.png", "Mozzarella"));

void AddPizzaToFactory(FlyweightFactory factory, IPizza pizza)
{
    Console.WriteLine("Adding pizza to FlyweightFactory");
    var flyweight = factory.GetFlyweight(pizza);

    flyweight.CheckStates(pizza);
}