// See https://aka.ms/new-console-template for more information
using AbstractFactory.enums;
using AbstractFactory.interfaces;
using AbstractFactory.models.PizzaStores;

PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();
chicagoPizzaStore.OrderPizza(PizzaType.Cheese);
chicagoPizzaStore.OrderPizza(PizzaType.Diablo);

PizzaStore nyPizzaStore = new NYPizzaStore();
nyPizzaStore.OrderPizza(PizzaType.Cheese);
nyPizzaStore.OrderPizza(PizzaType.Diablo);


chicagoPizzaStore.OrderPizza(PizzaType.Cezario);
nyPizzaStore.OrderPizza(PizzaType.Cezario);
