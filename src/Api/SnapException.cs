using System;

namespace Snap.Api
{
    /// <summary>
    /// Indicates an internal error in SNAP.
    /// Exception messages should not displayed to the user and are only exposed for debugging purposes.
    /// </summary>
    public sealed class SnapException : Exception
    {
        internal SnapException(string message)
            : base(message)
        { }

        internal SnapException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
