﻿// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.PedModel.Appearance;

using GTA.Native;
using System;
using Exceptions;
using JetBrains.Annotations;

/// <summary>
/// Provides methods and functions to manipulate ped head blend.
/// </summary>
[PublicAPI]
public class HeadBlend
{
    private readonly HeadBlendCustomizer _blendCustomizer;
    private float _shapeMix;
    private float _skinMix;

    internal HeadBlend(HeadBlendCustomizer customizer)
    {
        if (customizer.BasePed == null)
        {
            throw new ArgumentException("Null reference of base ped in the provided customizer.", nameof(customizer));
        }

        if (!customizer.BasePed.Exists())
        {
            throw new InvalidPoolObjectException(customizer.BasePed);
        }

        _blendCustomizer = customizer;
    }

    /// <summary>
    /// Gets or sets the mother to manipulate shape of this instance.
    /// </summary>
    /// <remarks>
    /// Parents (mother and fathers) shares the same registry, so it's possible to set Mother and Father to the same value.
    /// </remarks>
    public HeadBlendParent ShapeMother { get; set; }

    /// <summary>
    /// Gets or sets the father to manipulate shape of this instance.
    /// </summary>
    /// <remarks>
    /// Parents (mother and fathers) shares the same registry, so it's possible to set Mother and Father to the same value.
    /// </remarks>
    public HeadBlendParent ShapeFather { get; set; }

    /// <summary>
    /// Gets or sets the mother to manipulate skin of this instance.
    /// </summary>
    /// <remarks>
    /// Parents (mother and fathers) shares the same registry, so it's possible to set Mother and Father to the same value.
    /// </remarks>
    public HeadBlendParent SkinMother { get; set; }

    /// <summary>
    /// Gets or sets the father to manipulate skin of this instance.
    /// </summary>
    /// <remarks>
    /// Parents (mother and fathers) shares the same registry, so it's possible to set Mother and Father to the same value.
    /// </remarks>
    public HeadBlendParent SkinFather { get; set; }

    /// <summary>
    /// Gets or sets the genetic bias between <see cref="ShapeMother"/> and <see cref="ShapeFather"/> on the head base shape.
    /// </summary>
    /// <value>
    /// The genetic bias between <see cref="ShapeMother"/> and <see cref="ShapeFather"/>. Must between 1.0 and -1.0 (otherwise an exception will be thrown).
    /// If set to 1.0, the head base shape of the ped will follow <see cref="ShapeMother"/>; if set to -1.0, it will follow <see cref="ShapeFather"/> instead.
    /// </value>
    public float ShapeMix
    {
        get => _shapeMix;
        set
        {
            if (value > 1.0f || value < -1.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Value should between 1.0 and -1.0.");
            }

            _shapeMix = value;
        }
    }

    /// <summary>
    /// Gets or sets the genetic bias between <see cref="ShapeMother"/> and <see cref="ShapeFather"/> on the skin color (tone).
    /// </summary>
    /// <value>
    /// The genetic bias between <see cref="ShapeMother"/> and <see cref="ShapeFather"/>. Must between 1.0 and -1.0 (otherwise an exception will be thrown).
    /// If set to 1.0, the skin color (tone) of the ped will follow <see cref="ShapeMother"/>; if set to -1.0, it will follow <see cref="ShapeFather"/> instead.
    /// </value>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when the specified value out of range of <c>1.0f</c> and <c>-1.0f</c>.</exception>
    public float SkinMix
    {
        get => _skinMix;
        set
        {
            if (value > 1.0f || value < -1.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Value should between 1.0 and -1.0.");
            }

            _skinMix = value;
        }
    }

    /// <summary>
    /// Gets or sets the extra factor of the shape.
    /// </summary>
    public int ShapeExtraFactor { get; set; }

    /// <summary>
    /// Gets or sets the extra factor of the skin.
    /// </summary>
    public int SkinExtraFactor { get; set; }

    /// <summary>
    /// Gets or sets the extra factor when mixing skin and shapes.
    /// </summary>
    public float MixExtraFactor { get; set; }

    /// <summary>
    /// Applies the configuration of this instance to the ped.
    /// </summary>
    /// <remarks>
    /// It is impossible to set values directly as we cannot read these. Thus, you'll need to set the values first, then
    /// apply it using this method.
    /// </remarks>
    public void Apply()
    {
        Function.Call(Hash.SET_PED_HEAD_BLEND_DATA, _blendCustomizer.BasePed, (int)ShapeMother, (int)ShapeFather, ShapeExtraFactor, (int)SkinMother, (int)SkinFather, SkinExtraFactor, ShapeMix, SkinMix, MixExtraFactor, false);
    }
}