using Proxy.interfaces;

namespace Proxy.models
{
    internal class ProxySubject : ISubject
    {
        private RealSubject _subject;

        public ProxySubject(RealSubject subject)
            => (_subject) = (subject);

        public void Process()
        {
            if(HasAccess())
            {
                _subject.Process();
            }
        }

        private bool HasAccess()
        {
            if (_subject == null)
                return false;

            //Check here something you need for access
            Console.WriteLine("Checking some specifics for having access...");

            return true;
        }
    }
}
