// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities.PedModel.Appearance;

using GTA.Native;
using System;
using Exceptions;
using JetBrains.Annotations;

/// <summary>
/// Provides methods and properties to manipulate head overlay.
/// </summary>
[PublicAPI]
public class HeadOverlay
{
    private readonly HeadBlendCustomizer _customizer;
    private readonly HeadOverlayType _type;

    internal HeadOverlay(HeadBlendCustomizer customizer, HeadOverlayType type)
    {
        _customizer = customizer;
        _type = type;
    }

    /// <summary>
    /// Gets or sets the opacity used when setting <see cref="Index"/> next time. This value will not be effective until next call to <see cref="Index"/>'s setter.
    /// </summary>
    public float Opacity { get; set; } = 1.0f;

    /// <summary>
    /// Gets the index of this instance.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when the <see cref="HeadBlendCustomizer"/> or it's <see cref="GTA.Ped"/> was null, or when <see cref="HeadBlendCustomizer.BasePed"/> was invalid.</exception>
    public int Index
    {
        get
        {
            if (_customizer == null) throw new InvalidOperationException("Customizer was null.");
            if (_customizer.BasePed == null) throw new InvalidOperationException("Customizer base ped was null.");
            if (!_customizer.BasePed.Exists()) throw new InvalidOperationException("Customizer base ped was invalid.");

            return Function.Call<int>(Hash._GET_PED_HEAD_OVERLAY_VALUE, _customizer.BasePed, _type);
        }
        set
        {
            if (_customizer == null) throw new InvalidOperationException("Customizer was null.");
            if (_customizer.BasePed == null) throw new InvalidOperationException("Customizer base ped was null.");
            if (!_customizer.BasePed.Exists()) throw new InvalidOperationException("Customizer base ped was invalid.");

            Function.Call(Hash.SET_PED_HEAD_OVERLAY, _customizer.BasePed, (int)_type, value, Opacity);
        }
    }

    /// <summary>
    /// Sets the color of this instance. Recommended to call right after setting <see cref="Index"/>. The type of the color is automatically determined based on <see cref="HeadOverlayType"/>.
    /// </summary>
    /// <param name="firstId">The first color Id.</param>
    /// <param name="secondId">The second color Id.</param>
    /// <exception cref="InvalidOperationException">Thrown when the <see cref="HeadOverlayType"/> of this instance does not allow colors, or when <see cref="HeadBlendCustomizer"/>'s ped was null.</exception>
    /// <exception cref="InvalidPoolObjectException">Thrown when the ped of <see cref="HeadBlendCustomizer"/> of this instance invalidates.</exception>
    public void SetColor(int firstId, int secondId)
    {
        if (_customizer == null) throw new InvalidOperationException("Customizer was null.");
        if (_customizer.BasePed == null) throw new InvalidOperationException("Customizer base ped was null.");
        if (!_customizer.BasePed.Exists()) throw new InvalidPoolObjectException(_customizer.BasePed);

        int colorType;
        switch (_type)
        {
            case HeadOverlayType.Eyebrows:
            case HeadOverlayType.FacialHair:
            case HeadOverlayType.ChestHair:
                colorType = 1;
                break;

            case HeadOverlayType.Blush:
            case HeadOverlayType.Lipstick:
                colorType = 2;
                break;

            default:
                throw new InvalidOperationException("The type of this instance does not allow colors.");
        }

        Function.Call(Hash._SET_PED_HEAD_OVERLAY_COLOR, _customizer.BasePed, _type, colorType, firstId, secondId);
    }
}