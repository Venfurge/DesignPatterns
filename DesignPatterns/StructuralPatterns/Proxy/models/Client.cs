using Proxy.interfaces;

namespace Proxy.models
{
    internal class Client
    {
        private ISubject _subject;

        public Client(ISubject subject)
            => (_subject) = (subject);

        public void RunClientCode()
        {
            _subject.Process();
        }
    }
}
