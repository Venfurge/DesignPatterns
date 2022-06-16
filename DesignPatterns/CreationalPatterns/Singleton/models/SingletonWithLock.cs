namespace Singleton.models
{
    //Singleton with lock
    //Lazy
    //Thread-safe using lock
    //Lower perfomance
    internal sealed class SingletonWithLock
    {
        private static SingletonWithLock? instance = null;
        private static readonly object padlock = new object();

        private SingletonWithLock() { }

        public static SingletonWithLock Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonWithLock();
                    }

                    return instance;
                }
            }
        }

        //Value to test singleton
        public string Value { get; set; } = "Singleton with lock";
    }
}
