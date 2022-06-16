namespace Singleton.models
{
    //Singleton with double lock
    //Lazy
    //Thread-safe using lock
    //Higher perfomance
    internal sealed class SingletonWithLockDoubleCheck
    {
        private static SingletonWithLockDoubleCheck? instance = null;
        private static readonly object padlock = new object();

        private SingletonWithLockDoubleCheck() { }

        public static SingletonWithLockDoubleCheck Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new SingletonWithLockDoubleCheck();
                        }
                    }
                }

                return instance;
            }
        }

        //Value to test singleton
        public string Value { get; set; } = "Singleton with lock and double check";
    }
}
