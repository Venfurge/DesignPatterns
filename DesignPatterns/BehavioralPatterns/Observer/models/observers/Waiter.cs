using Observer.interfaces;

namespace Observer.models.observers
{
    internal class Waiter : IObserver
    {
        private Pizza? pizza;
        private ISubject pizzaSubject;

        public Waiter(ISubject PizzaSubject)
        {
            this.pizzaSubject = PizzaSubject;
            this.pizzaSubject.RegisterObserver(this);
        }

        public void Update(Pizza pizza)
        {
            this.pizza = pizza;
            this.Display();
        }

        public void Display()
        {
            Console.WriteLine($"Hey Waiter. {pizza?.Name} is completed. You can give it to guest");
        }
    }
}
