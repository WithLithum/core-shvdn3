// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.UI;

/// <summary>
/// Represents a substring text label, which replaces <c>~s~</c> in translatable texts.
/// </summary>
public abstract class Text
{
    /// <summary>
    /// Adds this instance as substring.
    /// </summary>
    public abstract void Add();
}