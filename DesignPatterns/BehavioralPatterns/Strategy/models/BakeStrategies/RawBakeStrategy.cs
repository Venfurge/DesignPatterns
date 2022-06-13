using Strategy.interfaces;

namespace Strategy.models.BakeStrategies
{
    internal class RawBakeStrategy : IBakeStrategy
    {
        public void Bake()
        {
            Console.WriteLine("No to bake with. Pizza is raw");
        }
    }
}
