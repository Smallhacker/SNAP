using System.Collections.Generic;

namespace Snap.Api
{
    /// <summary>
    /// Contains a message (either a warning or an error) giving information about problems with the ASM code, as well as what part of the code caused the message.
    /// </summary>
    public interface ISnapMessage
    {
        /// <summary>
        /// A user-readable message. Will not be null.
        /// </summary>
        string Message { get; }

        /// <summary>
        /// The 1-indexed row number in the original ASM code, if known or applicable. Otherwise, null.
        /// </summary>
        uint? Row { get; }

        /// <summary>
        /// The 1-indexed column number (inside the row identified by the Row property) in the original ASM code, if known or applicable. Otherwise, null.
        /// </summary>
        /// <remarks>
        /// Will always be null if Row is null; the reverse is not guaranteed.
        /// </remarks>
        uint? Column { get; }

        /// <summary>
        /// A list of lines of text that form an ASCII image pointing to where in the ASM code the message is located.
        /// If none is available, this list is empty. Neither the list nor its elements will be null.
        /// </summary>
        /// <remarks>
        /// Intended to be displayed in a monospaced font.
        /// </remarks>
        IReadOnlyList<string> LocationView { get; }
    }
}
