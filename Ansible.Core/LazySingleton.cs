using System;

namespace Ansible
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton> Lazy = new Lazy<LazySingleton>(() => new LazySingleton());

        private LazySingleton() { }

        public static LazySingleton Instance => Lazy.Value;
    }
}