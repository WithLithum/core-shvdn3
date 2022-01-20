// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.UI;

using JetBrains.Annotations;
using Util.Native;

/// <summary>
/// Represents a GXT text label.
/// </summary>
[PublicAPI]
public class TranslatableText : Text
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TranslatableText"/> class.
    /// </summary>
    /// <param name="label">The label.</param>
    public TranslatableText(string label)
    {
        Label = label;
    }

    /// <summary>
    /// Gets or sets the label of this instance.
    /// </summary>
    public string Label { get; set; }

    /// <inheritdoc />
    public override void Add()
    {
        Api.AddTextComponentSubstringTextLabel(Label);
    }
}