using System.Threading;

namespace Ansible.Threading
{
    /// <summary>
    /// Singleton Design Pattern for multi-thread environment
    /// </summary>
    /// <remarks>The monitor mechanism gives the greatest control over locking use cases.</remarks>
    public sealed class MonitorSingleton
    {
        private static readonly object _sync = new object();
        private static MonitorSingleton _instance;

        private MonitorSingleton()
        {
        }

        public static MonitorSingleton Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                Monitor.Enter(_sync);

                var single = new MonitorSingleton();
                Interlocked.Exchange(ref _instance, single);

                Monitor.Exit(_sync);

                return _instance;
            }
        }
    }
}
