// See https://aka.ms/new-console-template for more information
using Composite.interfaces;
using Composite.models;

Menu pizzaStoreMenu = new Menu("Pizza Store Menu", new List<IMenu>());

//Adding Italy Menu
List<IMenu> italyPizzas = new List<IMenu>();
italyPizzas.Add(new Pizza("Mozzarella", "chessy one", 2.99));
italyPizzas.Add(new Pizza("Chipolla", "onion one", 3.99));
italyPizzas.Add(new Pizza("Diabola", "hot one", 2.99));

Menu italyPizzaMenu = new Menu("Italy pizza", italyPizzas);
pizzaStoreMenu.AddMenuChild(italyPizzaMenu);

//Adding American Menu
List<IMenu> americanPizzas = new List<IMenu>();
americanPizzas.Add(new Pizza("NY", "thin dought", 2.99));
americanPizzas.Add(new Pizza("Chicago", "rought dought", 3.99));

Menu americanPizzasMenu = new Menu("American pizza", americanPizzas);
pizzaStoreMenu.AddMenuChild(americanPizzasMenu);

//Adding Own Pizzas
Pizza meatBallPizza = new Pizza("MeatBall", "pizza with meat balls", 3.49);
Pizza quatrostagionyPizza = new Pizza("Quatrostagiony", "4 cheese pizza", 4.99);
Pizza pineapplePizza = new Pizza("Pineapple", "pizza with pineapples", 3.99);
Pizza fatSalamiPizza = new Pizza("FatSalamiPizza", "pizza with a lot of salami slices", 4.99);

pizzaStoreMenu.AddMenuChild(meatBallPizza);
pizzaStoreMenu.AddMenuChild(quatrostagionyPizza);
pizzaStoreMenu.AddMenuChild(pineapplePizza);
pizzaStoreMenu.AddMenuChild(fatSalamiPizza);

pizzaStoreMenu.PrintMenu();
Console.WriteLine($"Whole menu price: {pizzaStoreMenu.GetPrice()}");
