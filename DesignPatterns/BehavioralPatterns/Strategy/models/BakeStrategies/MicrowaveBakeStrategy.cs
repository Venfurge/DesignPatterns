using Strategy.interfaces;

namespace Strategy.models.BakeStrategies
{
    internal class MicrowaveBakeStrategy : IBakeStrategy
    {
        public void Bake()
        {
            Console.WriteLine("Baked by microwave");
        }
    }
}
