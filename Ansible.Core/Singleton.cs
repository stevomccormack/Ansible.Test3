﻿namespace Ansible
{
    /// <summary>
    /// Singleton Design Pattern for single thread environment
    /// </summary>
    /// <remarks>Basic use case for singleton.</remarks>
    public sealed class Singleton
    {
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

                _instance = new Singleton();
                return _instance;
            }
        }
    }
}