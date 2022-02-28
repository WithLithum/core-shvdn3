// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities;

using GTA;
using JetBrains.Annotations;
using PedModel.Appearance;
using System;
using System.Collections.Generic;
using WithLithum.Core.Exceptions;

/// <summary>
/// Provide extension methods to <see cref="Ped"/> class.
/// </summary>
[PublicAPI]
public static class PedExtensions
{
    private static readonly Dictionary<Ped, HeadBlendCustomizer> _customizers = new();
    private static readonly Dictionary<Ped, PedAttributor> _attributors = new();

    /// <summary>
    /// Receives an instance of <see cref="PedAttributor"/>.
    /// </summary>
    /// <param name="ped">The ped.</param>
    /// <returns>An instance of <see cref="PedAttributor"/>.</returns>
    /// <exception cref="ArgumentNullException">The ped was null.</exception>
    /// <exception cref="InvalidPoolObjectException">The ped was invalid.</exception>
    public static PedAttributor Attributor(this Ped ped)
    {
        if (ped == null)
        {
            _attributors.Remove(ped);
            throw new ArgumentNullException(nameof(ped));
        }

        if (!ped.Exists())
        {
            _attributors.Remove(ped);
            throw new InvalidPoolObjectException(ped);
        }

        if (!_attributors.ContainsKey(ped))
        {
            _attributors[ped] = new PedAttributor(ped);
        }

        return _attributors[ped];
    }

    /// <summary>
    /// Receives an instance of <see cref="HeadBlendCustomizer"/> which can be used to edit the face features,
    /// head blend data, etc. of this instance.
    /// </summary>
    /// <param name="ped">The ped.</param>
    /// <returns>An instance of <see cref="HeadBlendCustomizer"/>. Multiple calls with the same instance will return the same instance.</returns>
    public static HeadBlendCustomizer HeadBlend(this Ped ped)
    {
        if (ped == null)
        {
            _customizers.Remove(ped);
            throw new ArgumentNullException(nameof(ped));
        }

        if (!ped.Exists())
        {
            _customizers.Remove(ped);
            throw new InvalidPoolObjectException(ped);
        }

        if (!_customizers.ContainsKey(ped))
        {
            _customizers[ped] = new HeadBlendCustomizer(ped);
        }

        return _customizers[ped];
    }
}