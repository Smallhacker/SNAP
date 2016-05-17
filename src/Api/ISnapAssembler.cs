using System.Collections.Generic;

namespace Snap.Api
{
    /// <summary>
    /// Assembles 65c816 ASM code into machine code.
    /// </summary>
    public interface ISnapAssembler
    {
        /// <summary>
        /// Assembles the provided lines of ASM code to machine code located at the provided address.
        /// </summary>
        /// <param name="baseAddress">PC address of where the assembled code should start.</param>
        /// <param name="lines">Individual lines of ASM code. Should not contain newlines. Empty lines are ignored.</param>
        /// <returns>ISnapOutput instance containing the result of the assembly.</returns>
        /// <exception cref="ArgumentException">Thrown when this method is called with invalid arguments. This does not include errors in the ASM code (which are reported as part of the method's return value).</exception>
        /// <exception cref="SnapException">Thrown when internal errors occurs.</exception>
        ISnapOutput Assemble(uint baseAddress, IEnumerable<string> lines);
    }
}
