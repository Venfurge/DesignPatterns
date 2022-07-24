namespace Mediator.interfaces
{
    internal class Handler
    {
        protected IMediator? mediator;

        public Handler(IMediator mediator = null)
        {
            this.mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
