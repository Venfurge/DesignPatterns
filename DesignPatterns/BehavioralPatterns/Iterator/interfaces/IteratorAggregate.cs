using System.Collections;

namespace Iterator.interfaces
{
    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
