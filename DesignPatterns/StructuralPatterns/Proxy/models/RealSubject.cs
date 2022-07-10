using Proxy.interfaces;

namespace Proxy.models
{
    internal class RealSubject : ISubject
    {
        public void Process()
        {
            Console.WriteLine("Real subject making some process...");
        }
    }
}
