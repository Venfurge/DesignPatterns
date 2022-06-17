// See https://aka.ms/new-console-template for more information
using Facade.interfaces;
using Facade.models;
using Facade.models.boxingStrategies;
using Facade.models.cuttingStrategies;

IPizza pizza = new CheesePizza("Mozzarella", 2.99);
Oven.Bake(pizza);

ICuttingStrategy cuttingStrategy = new SquareCutStrategy();
CuttingTable cuttingTable = new CuttingTable(cuttingStrategy);
cuttingTable.Cut(pizza);

IBoxingStrategy boxingStrategy = new SquareBoxStrategy();
BoxingTable boxingTable = new BoxingTable(boxingStrategy);
boxingTable.Box(pizza);

if(pizza.isCutted && pizza.isBoxed)
{
    Console.WriteLine($"{pizza.Name} pizza is prepared");
}