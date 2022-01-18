// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities.Util;

using GTA.Math;

/// <summary>
/// Represents an entity that is locatable.
/// </summary>
public interface ISpatial
{
    /// <summary>
    /// Gets or sets the position of this instance.
    /// </summary>
    Vector3 Position { get; set; }
}