namespace Mediator.interfaces
{
    internal interface IMediator
    {
        void Notify(object sender, string type);
    }
}
