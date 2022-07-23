namespace Memento.interfaces
{
    internal abstract class AbstractMemento
    {
        public abstract object GetState();
        public abstract DateTime GetDate();
    }
}
