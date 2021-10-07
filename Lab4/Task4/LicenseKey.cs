using System;

namespace Task4
{
    public static class LicenseKey
    {
        public static readonly Guid Pro = Guid.NewGuid();
        public static readonly Guid Trial = Guid.NewGuid();
    }
}
