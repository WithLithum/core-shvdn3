﻿namespace WithLithum.Core.Entities;

using GTA;
using JetBrains.Annotations;
using System;
using Attributing;
using Exceptions;
using Util.Native;

/// <summary>
/// Provides extensions of the entity class.
/// </summary>
[PublicAPI]
public class EntityAttributor : IAttributor<Entity>
{
    private Entity _internal;

    static EntityAttributor()
    {
        AttributorManager.RegisterAttributor<Entity, EntityAttributor>();
    }

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    public static void Init()
    {
        // null-sub to trigger the static
    }

    /// <inheritdoc />
    public void Apply(Entity value)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));
        if (!value.Exists()) throw new ArgumentException("Invalid value", nameof(value));

        _internal = value;
    }

    private Entity RequiresValid()
    {
        if (_internal?.Exists() != true) throw new InvalidPoolObjectException("Invalid internal!");
        return _internal;
    }

    /// <summary>
    /// Sets the lights of this instance.
    /// </summary>
    /// <param name="value">Whether is on.</param>
    public void SetLightsOn(bool value)
    {
        Api.SetEntityLights(RequiresValid().Handle, value);
    }
}