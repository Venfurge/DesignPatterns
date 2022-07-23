// See https://aka.ms/new-console-template for more information
using Memento.models;

var order = new Order(new List<Pizza>() {
    new Pizza("Mozzarella", 4.99)
});

var careTaker = new OrderCaretaker(order);

order.ProduceAnOrder();
careTaker.Backup();

order.ChangeOrder(new List<Pizza>() {
    new Pizza("Mozzarella", 4.99),
    new Pizza("Salami", 5.99)
});

order.ProduceAnOrder();
careTaker.Undo();
order.ProduceAnOrder();
