using Adapter.interfaces;

namespace Adapter.models
{
    //Imagine that we can't modify this class
    //For example: this class is from 3rd party library
    //But you still need to use it's method Prepare
    internal static class PizzaOven
    {
        public static void Prepare(IPizza pizza)
        {
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
