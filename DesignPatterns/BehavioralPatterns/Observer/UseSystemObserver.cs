using Observer.models;

namespace Observer
{
    internal static class UseSystemObserver
    {
        public static void Execute()
        {
            Oven oven = new Oven(new Pizza("Cheese", 2));
            IObserver<Pizza> clientApp = new ClientApplication();
            oven.Subscribe(clientApp);

            oven.BakePizza(new Pizza("Bacon", 2.99));

            IObserver<Pizza> courier = new Courier();
            oven.Subscribe(courier);

            oven.BakePizza(new Pizza("Salmon", 4.49));
        }
    }

    internal class Oven : IObservable<Pizza>
    {
        private List<IObserver<Pizza>> _observers
            = new List<IObserver<Pizza>>();
        private Pizza pizza;

        public Oven(Pizza Pizza) => (pizza) = (Pizza);

        public IDisposable Subscribe(IObserver<Pizza> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                observer.OnNext(pizza);
            }

            return new Unsubscriber<Pizza>(_observers, observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer => observer.OnNext(pizza));
        }

        public void BakePizza(Pizza pizza)
        {
            this.pizza = pizza;
            pizza.BakePizza();
            NotifyObservers();
        }
    }

    internal class Unsubscriber<Pizza> : IDisposable
    {
        private List<IObserver<Pizza>> _observers;
        private IObserver<Pizza> _observer;

        internal Unsubscriber(List<IObserver<Pizza>> observers, IObserver<Pizza> observer)
        {
            this._observers = observers;
            this._observer = observer;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }

    internal class ClientApplication : IObserver<Pizza>
    {
        private Pizza? pizza;
        private IDisposable? cancellation;

        public virtual void Subscribe(Oven provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation?.Dispose();
            pizza = null;
        }

        public void OnNext(Pizza value)
        {
            pizza = value;
            Display();
        }

        public void OnCompleted()
        {
            this.pizza = null;
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            Console.WriteLine($"Hey 'ClientName'. {pizza?.Name} is completed");
        }
    }

    internal class Courier : IObserver<Pizza>
    {
        private Pizza? pizza;
        private IDisposable? cancellation;

        public virtual void Subscribe(Oven provider)
        {
            cancellation = provider.Subscribe(this);
        }

        public virtual void Unsubscribe()
        {
            cancellation?.Dispose();
            pizza = null;
        }

        public void OnNext(Pizza value)
        {
            pizza = value;
            Display();
        }

        public void OnCompleted()
        {
            pizza = null;
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            Console.WriteLine($"Hey Courier. {pizza?.Name} is completed. You can take it and deliver");
        }
    }
}
