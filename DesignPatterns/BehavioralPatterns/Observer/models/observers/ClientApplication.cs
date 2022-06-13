using Observer.interfaces;

namespace Observer.models.observers
{
    internal class ClientApplication : IObserver
    {
        private Pizza? pizza;
        private ISubject pizzaSubject;

        public ClientApplication(ISubject PizzaSubject)
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
            Console.WriteLine($"Hey 'ClientName'. {pizza?.Name} is completed");
        }
    }
}
