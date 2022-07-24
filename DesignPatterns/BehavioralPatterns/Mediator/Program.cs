// See https://aka.ms/new-console-template for more information
using Mediator.models;
using Mediator.models.handlers;

Pizza pizza = new Pizza("Mozzarella", 4.99);
pizza.Print();

Oven oven = new Oven();
CuttingTable cuttingTable = new CuttingTable();
BoxingTable boxingTable = new BoxingTable();

var pizzaStore = new PizzaStore(oven, cuttingTable, boxingTable);

oven.BakePizza(pizza);
cuttingTable.CutPizza(pizza);

pizza.Print();
boxingTable.BoxPizza(pizza);

pizza.Print();