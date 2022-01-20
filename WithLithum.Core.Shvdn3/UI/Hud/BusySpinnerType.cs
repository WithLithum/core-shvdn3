// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.UI.Hud;

using JetBrains.Annotations;

/// <summary>
/// An enumeration of all possible busy spinner types.
/// </summary>
[PublicAPI]
public enum BusySpinnerType
{
    /// <summary>
    /// Left side of the screen.
    /// </summary>
    Left,

    /// <summary>
    /// Left side of the screen.
    /// </summary>
    Left2,

    /// <summary>
    /// Left side of the screen.
    /// </summary>
    Left3,

    /// <summary>
    /// Saving. No background.
    /// </summary>
    Save,

    /// <summary>
    /// Traditional at right side of the screen.
    /// </summary>
    Right,
}