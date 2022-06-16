// See https://aka.ms/new-console-template for more information
using Command.models;
using Command.models.commands;

Cook oven = new Cook(300, "Fast bake");
Pizza pizza = new Pizza("Cheese");

oven.setBakeCommand(new BakeCommand(pizza));
oven.setCutCommand(new CutDiagonalCommand(pizza));
oven.setBoxCommand(new BoxCommand(pizza));

oven.UnBox();

oven.Bake();
oven.Cut();
oven.Box();
oven.UnBox();