// See https://aka.ms/new-console-template for more information
using State.models;

PizzaMachine pizzaMachine = new PizzaMachine(5);

pizzaMachine.InsertMoney();
pizzaMachine.ChoosePizza();

pizzaMachine.InsertMoney();
pizzaMachine.ReturnMoney();
pizzaMachine.ChoosePizza();

pizzaMachine.InsertMoney();
pizzaMachine.ChoosePizza();
pizzaMachine.InsertMoney();
pizzaMachine.ChoosePizza();
pizzaMachine.ReturnMoney();

pizzaMachine.InsertMoney();
pizzaMachine.InsertMoney();
pizzaMachine.ChoosePizza();
pizzaMachine.InsertMoney();
pizzaMachine.ChoosePizza();
pizzaMachine.InsertMoney();
pizzaMachine.ChoosePizza();