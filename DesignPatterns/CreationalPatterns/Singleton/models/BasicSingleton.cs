namespace Singleton.models
{
    //Basic Singleton
    //Lazy
    //Not thread-safe.
    internal sealed class BasicSingleton
    {
        private static BasicSingleton? instance = null;
        private BasicSingleton() { }

        public static BasicSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BasicSingleton();
                }

                return instance;
            }
        }

        //Value to test singleton
        public string Value { get; set; } = "Basic Singleton";
    }
}
