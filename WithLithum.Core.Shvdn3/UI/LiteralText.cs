// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.UI;

using WithLithum.Core.Util.Native;

/// <summary>
/// Represents a literal text. Also known as player name substring.
/// </summary>
public sealed class LiteralText : Text
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LiteralText"/> class.
    /// </summary>
    /// <param name="value">The value.</param>
    public LiteralText(string value)
    {
        Value = value;
    }

    /// <summary>
    /// Gets or sets the value of this instance.
    /// </summary>
    public string Value { get; set; }

    /// <inheritdoc />
    public override void Add()
    {
        Api.AddTextComponentSubstringPlayerName(Value);
    }
}