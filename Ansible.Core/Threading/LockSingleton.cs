namespace Ansible.Threading
{
    /// <summary>
    /// Singleton Design Pattern for multi-thread environment
    /// </summary>
    /// <remarks>Uses double-checked locking method - effective but expensive locking mechanism with least control.</remarks>
    public sealed class LockSingleton
    {
        private static readonly object _sync = new object();
        private static LockSingleton _instance;

        private LockSingleton()
        {
        }

        public static LockSingleton Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                lock( _sync )
                {
                    _instance = new LockSingleton();
                    return _instance;
                }
            }
        }
    }
}