using ChainOfResponsibility.interfaces;

namespace ChainOfResponsibility.models.handlers
{
    internal class BoxingHandler : AbstractHandler
    {
        private BoxingTable _boxingTable;
        public BoxingHandler(BoxingTable boxingTable)
            => (_boxingTable) = (boxingTable);

        public override object? Handle(object request)
        {
            try
            {
                _boxingTable.Box((Pizza)request);
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
