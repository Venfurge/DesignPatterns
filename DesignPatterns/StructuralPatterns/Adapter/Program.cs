// See https://aka.ms/new-console-template for more information
using Adapter.models;

CheesePizza pizza = new CheesePizza("Cheese");
PizzaOven.Prepare(pizza);

BerryPie pie = new BerryPie("Strawberry");
PizzaPieAdapter adapter = new PizzaPieAdapter(pie);
PizzaOven.Prepare(adapter);