using Strategy.interfaces;

namespace Strategy.models.BakeStrategies
{
    internal class OvenBakeStrategy : IBakeStrategy
    {
        public void Bake()
        {
            Console.WriteLine("Baked by oven");
        }
    }
}
