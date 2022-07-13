using Flyweight.interfaces;

namespace Flyweight.models
{
    internal class FlyweightFactory
    {
        private List<KeyValuePair<string, Flyweight>> _flyweights = new List<KeyValuePair<string, Flyweight>>();

        public FlyweightFactory(List<IPizza> pizzas)
        {
            pizzas.ForEach(pizza => 
                _flyweights.Add(
                    new KeyValuePair<string, Flyweight>(
                        getKey(pizza), new Flyweight(pizza)
                    )
                ));
        }

        public string getKey(IPizza pizza)
        {
            List<string> elements = new List<string>();

            elements.Add(pizza.ImageUrl);
            elements.Add(pizza.Price.ToString());

            if (pizza.Name != null && pizza.Description != null)
            {
                elements.Add(pizza.Name);
                elements.Add(pizza.Description);
            }

            elements.Sort();

            return String.Join("_", elements);
        }

        public Flyweight GetFlyweight(IPizza sharedState)
        {
            string key = getKey(sharedState);

            if (_flyweights.Where(f => f.Key == key).Count() == 0)
            {
                Console.WriteLine("Log: FlyweightFactory can't find a flyweight. Creating new one");
                _flyweights.Add(new KeyValuePair<string, Flyweight>(key, new Flyweight(sharedState)));
            }
            else
            {
                Console.WriteLine("Log: FlyweightFactory finds flyweight. Reusing existing flyweight.");
            }

            return _flyweights.Where(f => f.Key == key).FirstOrDefault().Value;
        }

        public void PrintFlyweights()
        {
            var count = _flyweights.Count;
            Console.WriteLine($"FlyweightFactory: There are {count} flyweights");
            _flyweights.ForEach(f => f.Value.Print());
        }
    }
}
