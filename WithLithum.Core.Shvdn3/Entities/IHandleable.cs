namespace WithLithum.Core.Entities;
using System.Collections.Generic;

/// <summary>
/// Represents an object that has handle.
/// </summary>
/// <remarks>
/// Entities are store internally in RAGE as <see cref="Dictionary{TKey, TValue}"/> with the
/// <see cref="Handle"/> being the key.
/// <para>
/// They are validated by checking the if the index of the handle using <see cref="Dictionary{TKey, TValue}.ContainsKey(TKey)"/>.
/// </para>
/// <note type="warning">
/// All of the managed types and methods are for example purposes only - RAGE does <b>not</b> use CLR types.
/// </note>
/// </remarks>
public interface IHandleable
{
    /// <summary>
    /// Gets the handle of this instance.
    /// </summary>
    /// <value>
    /// The handle of this instance.
    /// </value>
    uint Handle { get; }

    /// <summary>
    /// Determines whether this instance still represents a valid object instance in the
    /// game world.
    /// </summary>
    /// <returns><see langword="true"/> if this instance still represents a valid object instance in the
    /// game world; otherwise, <see langword="false"/>.</returns>
    bool IsValid();
}
