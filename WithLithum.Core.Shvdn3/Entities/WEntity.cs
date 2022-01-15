namespace WithLithum.Core.Entities;
using GTA;
using GTA.Math;
using System;
using System.ComponentModel;
using WithLithum.Core.Entities.Util;
using WithLithum.Core.Exceptions;
using static WithLithum.Core.Util.Native.Api;

/// <summary>
/// Represents an entity in the game world.
/// </summary>
public abstract class WEntity : IHandleable, IDeletable, IAddressable, ISpatial, ILivable
{
    /// <inheritdoc />
    public uint Handle { get; protected set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is visible (rendered by client).
    /// </summary>
    /// <value>
    /// <see langword="true"/> if this instance is visible; otherwise, <see langword="false"/>.
    /// </value>
    public bool Visible
    {
        get
        {
            return IsEntityVisible(RequiresValid().Handle);
        }
        set
        {
            SetEntityVisible(RequiresValid().Handle, value);
        }
    }

    /// <summary>
    /// Gets a value indicating whether this instance is on fire.
    /// </summary>
    public bool IsOnFire
    {
        get
        {
            return IsEntityOnFire(RequiresValid().Handle);
        }
    }

    /// <summary>
    /// Gets a value indicating whether this instance is being locked by the game engine.
    /// </summary>
    /// <remarks>
    /// When an entity is being locked, it will not respond to <see cref="ApplyForce(ForceType, Vector3, Vector3, bool, bool)"/>,
    /// and the <see cref="Velocity"/> setter may not work. Also, combat tasks for peds may get ignored.
    /// </remarks>
    /// <value>
    /// <see langword="true"/> if this instance is being locked; otherwise, <see langword="false"/>.
    /// </value>
    public bool IsLockedByGameEngine
    {
        get
        {
            return IsEntityStatic(RequiresValid().Handle);
        }
    }

    /// <summary>
    /// Gets or sets the velocity of this instance.
    /// </summary>
    public Vector3 Velocity
    {
        get
        {
            return GetEntityVelocity(RequiresValid().Handle);
        }
        set
        {
            SetEntityVelocity(RequiresValid().Handle, value.X, value.Y, value.Z);
        }
    }

    /// <summary>
    /// Gets a value indicating whether this instance is dead.
    /// </summary>
    public bool IsDead
    {
        get
        {
            return IsEntityDead(RequiresValid().Handle);
        }
    }

    /// <summary>
    /// Gets a value indicating whether this instance is alive.
    /// </summary>
    public bool IsAlive => !IsDead;

    /// <inheritdoc />
    public int Health
    {
        get => GetEntityHealth(RequiresValid().Handle);
        set => SetEntityHealth(RequiresValid().Handle, value);
    }

    /// <inheritdoc/>
    public int MaxHealth
    {
        get => GetEntityMaxHealth(RequiresValid().Handle);
        set => SetEntityMaxHealth(RequiresValid().Handle, value);
    }

    /// <summary>
    /// Gets or sets the heading of the instance.
    /// </summary>
    /// <value>
    /// A <see cref="float"/> value, ranged in <c>0</c> to <c>359+</c>, representing the heading of this instance.
    /// </value>
    public float Heading
    {
        get
        {
            return GetEntityHeading(RequiresValid().Handle);
        }
        set
        {
            if (value >= 360f || value < 0f)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Heading must be in degrees (0f-359.99999+f).");
            }

            SetEntityHeading(RequiresValid().Handle, value);
        }
    }

    /// <summary>
    /// Gets the interior that this instance is currently in.
    /// </summary>
    /// <value>
    /// If inside any interior, the ID of such interior; otherwise, <c>0</c>.
    /// </value>
    public int CurrentInterior
    {
        get => GetInteriorFromEntity(RequiresValid().Handle);
    }

    /// <inheritdoc />
    public IntPtr MemoryAddress => SHVDN.NativeMemory.GetEntityAddress((int)RequiresValid().Handle);

    /// <inheritdoc />
    public Vector3 Position
    {
        get => GetEntityCoords(RequiresValid().Handle, false);
        set => SetEntityCoords(RequiresValid().Handle, value.X, value.Y, value.Z, false, false, false, false);
    }

    /// <summary>
    /// Sets a value indicating whether the light of this entity is on.
    /// </summary>
    /// <param name="on">On or off.</param>
    public void SetLightsOn(bool on)
    {
        SetEntityLights(RequiresValid().Handle, !on);
    }

    /// <inheritdoc />
    public void Delete()
    {
        var handle = RequiresValid().Handle;
        DeleteEntity(ref handle);
        Handle = handle;
    }

    /// <summary>
    /// Applies force to this instance.
    /// </summary>
    /// <param name="type">The type of the force to apply.</param>
    /// <param name="pos">The position of the force.</param>
    /// <param name="offset">The offset of the force.</param>
    /// <param name="isDirectionalRel">Vector defined in local (body-fixed) coordinate frame</param>
    /// <param name="isForceRel">When true, force gets multiplied with the objects mass and different objects will have the</param>
    public void ApplyForce(ForceType type, Vector3 pos, Vector3 offset, bool isDirectionalRel, bool isForceRel)
    {
        ApplyForceToEntity(RequiresValid().Handle, (int)type, pos.X, pos.Y, pos.Z, offset.X, offset.Y, offset.Z, 0, isDirectionalRel, false, isForceRel, false, true);
    }

    /// <inheritdoc />
    public void Kill()
    {
        this.Health = 0;
    }

    /// <summary>
    /// Determines whether this instance still represents a valid entity in the game world.
    /// </summary>
    /// <returns><inheritdoc /></returns>
    public bool IsValid()
    {
        return DoesEntityExist(Handle);
    }

    /// <summary>
    /// Requires this instance valid otherwise throw an exception.
    /// </summary>
    /// <exception cref="InvalidPoolObjectException">Thrown when this instance is invalid.</exception>
    /// <returns>This instance, for chaining.</returns>
    protected WEntity RequiresValid()
    {
        if (!IsValid()) throw new InvalidPoolObjectException(this);
        return this;
    }
}
