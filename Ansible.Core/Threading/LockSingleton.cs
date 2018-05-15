namespace Ansible.Threading
{
    public sealed class Singleton
    {
        private static readonly object _sync = new object();
        private static Singleton _instance;

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;

                lock( _sync )
                {
                    _instance = new Singleton();
                    return _instance;
                }
            }
        }
    }
}