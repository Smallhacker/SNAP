using System.Collections.Generic;

namespace Snap.Api
{
    /// <summary>
    /// Contains the result of assembling ASM code. 
    /// </summary>
    public interface ISnapOutput
    {
        /// <summary>
        /// Contains a list of contiguous areas of assembled code.
        /// </summary>
        /// <value>
        /// If the assembly was successful, this returns the assembled code. None of the elements will be null.
        /// If the assembly failed, this returns null.
        /// </value>
        IReadOnlyList<ISnapSegment> DataSegments { get; }

        /// <summary>
        /// Contains a list of errors encountered in the ASM code.
        /// </summary>
        /// <value>
        /// If the assembly was successful, this returns an empty list.
        /// If the assembly failed, this returns a list containing at least one error message.
        /// Neither the list nor its elements will be null.
        /// </value>
        IReadOnlyList<ISnapMessage> Errors { get; }

        /// <summary>
        /// Contains a list of warnings encountered in the ASM code.
        /// If no values are present, an empty list is returned.
        /// Neither the list nor its elements will be null.
        /// </summary>
        /// <remarks>
        /// Warnings may be provided whether or not the assembly succeded.
        /// </remarks>
        IReadOnlyList<ISnapMessage> Warnings { get; }
    }
}
