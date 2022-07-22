using ChainOfResponsibility.interfaces;

namespace ChainOfResponsibility.models.handlers
{
    internal class CuttingHandler : AbstractHandler
    {
        private CuttingTable _cuttingTable;
        public CuttingHandler(CuttingTable cuttingTable)
            => (_cuttingTable) = (cuttingTable);

        public override object? Handle(object request)
        {
            try
            {
                _cuttingTable.Cut((Pizza)request);
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
