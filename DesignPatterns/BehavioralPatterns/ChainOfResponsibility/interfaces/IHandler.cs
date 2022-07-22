namespace ChainOfResponsibility.interfaces
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);
        object? Handle(object request);
    }
}
