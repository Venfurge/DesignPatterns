using Observer.interfaces;

namespace Observer.models.observers
{
    internal class Courier : IObserver
    {
        private Pizza? pizza;
        private ISubject pizzaSubject;

        public Courier(ISubject PizzaSubject)
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
            Console.WriteLine($"Hey Courier. {pizza?.Name} is completed. You can take it and deliver");
        }
    }
}
