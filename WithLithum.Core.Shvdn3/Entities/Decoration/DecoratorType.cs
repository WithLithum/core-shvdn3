// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities.Decoration;

using JetBrains.Annotations;

/// <summary>
/// An enumeration of all possible types of an enumerator.
/// </summary>
[PublicAPI]
public enum DecoratorType
{
    /// <summary>
    /// Represents a decorator of <see cref="float"/>.
    /// </summary>
    Single = 1,

    /// <summary>
    /// Represents a decorator of <see cref="bool"/>.
    /// </summary>
    Boolean,

    /// <summary>
    /// Represents a decorator of <see cref="int"/>.
    /// </summary>
    Int32,

    /// <summary>
    /// Represents a decorator of an unknown type.
    /// </summary>
    Unknown,

    /// <summary>
    /// Represents a timestamp.
    /// </summary>
    TimeStamp
}