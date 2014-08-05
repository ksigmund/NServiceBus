namespace NServiceBus
{
    using System;

    /// <summary>
    /// Contains extension methods to NServiceBus.Configure
    /// </summary>
    public static class ConfigureInMemoryFaultManagement_obsolete
    {
        /// <summary>
        /// Use in-memory fault management.
        /// </summary>
        [ObsoleteEx(Replacement = "Configure.With(c => c.InMemoryFaultManagement())", RemoveInVersion = "6.0", TreatAsErrorFromVersion = "5.0")]
        public static Configure InMemoryFaultManagement(this Configure config)
        {
            throw new InvalidOperationException();
        }
    }
}