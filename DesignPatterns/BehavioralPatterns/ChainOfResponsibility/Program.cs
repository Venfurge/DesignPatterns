// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility.enums;
using ChainOfResponsibility.models;
using ChainOfResponsibility.models.handlers;

Pizza pizza = new Pizza("Mozzarella pizza");

var bakingHandler = new BakingHandler(new Oven());
var cuttingHandler = new CuttingHandler(new CuttingTable());
var boxingHandler = new BoxingHandler(new BoxingTable());

bakingHandler.SetNext(cuttingHandler).SetNext(boxingHandler);
bakingHandler.Handle(pizza);

Console.WriteLine($"Pizza: {pizza.Name} | Baked: {pizza.IsBaked} | Cutted: {pizza.IsCutted} | Boxed: {pizza.IsBoxed}");

var oven = new Oven();
oven.SetTemperature(300);
bakingHandler = new BakingHandler(oven);

bakingHandler.SetNext(cuttingHandler).SetNext(boxingHandler);
bakingHandler.Handle(pizza);
Console.WriteLine($"Pizza: {pizza.Name} | Baked: {pizza.IsBaked} | Cutted: {pizza.IsCutted} | Boxed: {pizza.IsBoxed}");

var cuttingTable = new CuttingTable();
cuttingTable.SetCuttingPattern(CuttingPattern.SquarePattern);
cuttingHandler = new CuttingHandler(cuttingTable);

bakingHandler.SetNext(cuttingHandler).SetNext(boxingHandler);
bakingHandler.Handle(pizza);

Console.WriteLine($"Pizza: {pizza.Name} | Baked: {pizza.IsBaked} | Cutted: {pizza.IsCutted} | Boxed: {pizza.IsBoxed}");