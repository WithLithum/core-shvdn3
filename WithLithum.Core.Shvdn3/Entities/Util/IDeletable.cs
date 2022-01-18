// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities.Util;

/// <summary>
/// Represents an object that can be deleted.
/// </summary>
public interface IDeletable
{
    /// <summary>
    /// Deletes this instance from the game world immediately, and sets the handle of this instance to
    /// <c>0</c>.
    /// </summary>
    /// <remarks>
    /// <note type="warning">
    /// Calls to an instance that has been deleted are invalid and will result in an exception.
    /// </note>
    /// <para>
    /// Note that you must remove this instance from a collection first if the collection uses <see cref="object.Equals(object)"/>
    /// for equality comparison, before deleting this instance.
    /// </para>
    /// </remarks>
    void Delete();
}