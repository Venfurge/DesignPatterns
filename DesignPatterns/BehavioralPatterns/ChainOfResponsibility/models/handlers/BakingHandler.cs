using ChainOfResponsibility.interfaces;

namespace ChainOfResponsibility.models.handlers
{
    internal class BakingHandler : AbstractHandler
    {
        private Oven _oven;
        public BakingHandler(Oven oven)
            => (_oven) = (oven);

        public override object? Handle(object request)
        {
            try
            {
                _oven.Bake((Pizza)request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return request;
            }

            return base.Handle(request);
        }
    }
}
