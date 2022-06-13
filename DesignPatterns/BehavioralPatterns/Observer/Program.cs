// See https://aka.ms/new-console-template for more information
using Observer.interfaces;
using Observer.models;
using Observer.models.observers;

Oven oven = new Oven(new Pizza("Cheese", 2));
IObserver clientApp = new ClientApplication(oven);
IObserver courier = new Courier(oven);

oven.BakePizza(new Pizza("Bacon", 2.99));

IObserver waiter = new Waiter(oven);

oven.BakePizza(new Pizza("Salmon", 4.49));