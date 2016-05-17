namespace Snap.Api
{
    /// <summary>
    /// Represents a contiguous segment of ROM data.
    /// </summary>
    public interface ISnapSegment
    {
        /// <summary>
        /// PC address of where this segment starts.
        /// </summary>
        uint Address { get; }

        /// <summary>
        /// An array of raw ROM data.
        /// </summary>
        byte[] Data { get; }
    }
}
