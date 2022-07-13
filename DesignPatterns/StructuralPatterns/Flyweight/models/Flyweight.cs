using Flyweight.interfaces;

namespace Flyweight.models
{
    internal class Flyweight
    {
        private IPizza _sharedState;

        public Flyweight(IPizza sharedState)
            => (_sharedState) = (sharedState);

        public void Print()
        {
            Console.WriteLine($"Name: {_sharedState.Name}, Description: {_sharedState.Description}, Price: {_sharedState.Price}, ImageUrl: {_sharedState.ImageUrl}");
        }

        public void CheckStates(IPizza uniqueState)
        {
            Console.WriteLine($"SharedState: \n");
            Print();

            Console.WriteLine($"Name: {uniqueState.Name}, Description: {uniqueState.Description}, Price: {uniqueState.Price}, ImageUrl: {uniqueState.ImageUrl}");

        }
    }
}
