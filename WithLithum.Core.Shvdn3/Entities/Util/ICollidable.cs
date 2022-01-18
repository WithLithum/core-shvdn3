// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities.Util;

/// <summary>
/// Represents an instance that can be collided with.
/// </summary>
public interface ICollidable
{
    /// <summary>
    /// Gets or sets whether this instance can be collided with.
    /// </summary>
    bool IsCollisionEnabled { get; }
}