// See https://aka.ms/new-console-template for more information
using TemplateMethod.interfaces;
using TemplateMethod.models;

Pizza pizza = new Pizza("cheese pizza");
PreparingMethod preparingMethod = new PizzaPreparingMethod();
preparingMethod.Prepare(pizza);

Pie pie = new Pie("strawberry pie");
preparingMethod = new PiePreparingMethod();
preparingMethod.Prepare(pie);
