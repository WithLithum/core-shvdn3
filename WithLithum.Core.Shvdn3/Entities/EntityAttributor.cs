namespace WithLithum.Core.Entities;

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
public class EntityAttributor
{
    private readonly Entity _internal;

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    public static void Init()
    {
        // null-sub to trigger the static
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EntityAttributor"/> class.
    /// </summary>
    /// <param name="value">The entity.</param>
    /// <exception cref="ArgumentNullException">The entity is null.</exception>
    /// <exception cref="ArgumentException">The entity is invalid.</exception>
    public EntityAttributor(Entity value)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));
        if (!value.Exists()) throw new ArgumentException("Invalid value", nameof(value));

        _internal = value;
    }

    /// <summary>
    /// Returns a valid instance of an entity.
    /// </summary>
    /// <returns>A valid instance.</returns>
    /// <exception cref="InvalidPoolObjectException">Instance is invalid.</exception>
    protected Entity RequiresValid()
    {
        if (_internal?.Exists() != true) throw new InvalidPoolObjectException("Invalid internal!");
        return _internal;
    }

    /// <summary>
    /// Determines whether this instance is the focus.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if this instance is focus; otherwise, <see langword="false"/>.
    /// </returns>
    public bool IsFocus()
    {
        return Api.IsEntityFocus(RequiresValid().Handle);
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