﻿// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities.PedModel.Appearance;

using JetBrains.Annotations;

/// <summary>
/// An enumeration of all possible head overlay types.
/// </summary>
/// <seealso cref="HeadOverlay"/>
/// <seealso cref="HeadBlendCustomizer"/>
[PublicAPI]
public enum HeadOverlayType
{
    /// <summary>
    /// The blemishes.
    /// </summary>
    Blemishes,

    /// <summary>
    /// The facial hair, also known as beard.
    /// </summary>
    FacialHair,

    /// <summary>
    /// The eyebrows.
    /// </summary>
    Eyebrows,

    /// <summary>
    /// The ageing effects.
    /// </summary>
    Ageing,

    /// <summary>
    /// The makeup effect on the whole face.
    /// </summary>
    Makeup,

    /// <summary>
    /// The blush effect.
    /// </summary>
    Blush,

    /// <summary>
    /// The complexion.
    /// </summary>
    Complexion,

    /// <summary>
    /// The effect of sun damage.
    /// </summary>
    SunDamage,

    /// <summary>
    /// The lipstick.
    /// </summary>
    Lipstick,

    /// <summary>
    /// The freckles.
    /// </summary>
    Freckles,

    /// <summary>
    /// The chest hair.
    /// </summary>
    ChestHair,

    /// <summary>
    /// The body blemishes.
    /// </summary>
    BodyBlemishes,

    /// <summary>
    /// Extra <see cref="BodyBlemishes"/>.
    /// </summary>
    ExtraBodyBlemishes
}