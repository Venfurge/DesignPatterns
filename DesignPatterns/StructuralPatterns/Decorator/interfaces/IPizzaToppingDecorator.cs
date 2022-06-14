namespace Decorator.interfaces
{
    internal interface IPizzaToppingDecorator : IPizza
    {
        public IPizza Pizza { get; set; }
    }
}
