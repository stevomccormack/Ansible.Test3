using System;

namespace Ansible
{
    /// <summary>
    /// Singleton Design Pattern for single thread environment
    /// </summary>
    /// <remarks>Uses lazy instantiation method.</remarks>
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> Lazy = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton() { }

        public static LazySingleton Instance => Lazy.Value;
    }
}