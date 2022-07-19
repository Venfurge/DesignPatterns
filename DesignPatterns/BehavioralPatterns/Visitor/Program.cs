// See https://aka.ms/new-console-template for more information
using Visitor.interfaces;
using Visitor.models.meals;
using Visitor.models.visitors;

void PrintMenu(List<IMenuComponent> menu, IVisitor visitor)
{
    menu.ForEach(component => component.AcceptVisitor(visitor));
}

List<IMenuComponent> menu = new List<IMenuComponent>
{
    new Pizza("Cheese", "Lots of mozzarella", 3.99),
    new Pizza("Pepperoni", "Lots of pepperoni", 4.99),
    new Hookah(3, "Melon and berries", 9.99),
    new Cocktail("Mohito", "Lite fresh cocktail", "Sprite, rum, sugar, mint, lime", 3.99),
    new Cocktail("Negroni", "A Negroni is an Italian cocktail. It is considered an aperitivo", "Campari, Gin, Sweet red Vermouth", 4.49)
};

var consoleVisitor = new ConsolePrintVisitor();
PrintMenu(menu, consoleVisitor);

var xmlVisitor = new XMLPrintVisitor();
PrintMenu(menu, xmlVisitor);