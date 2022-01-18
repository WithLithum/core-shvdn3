// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities;

using Exceptions;
using GTA;
using GTA.Math;
using System;
using Util;
using static WithLithum.Core.Util.Native.Api;
using IDeletable = Util.IDeletable;
using ISpatial = Util.ISpatial;

/// <summary>
/// Represents an entity in the game world.
/// </summary>
public abstract class WEntity : IHandleable, IDeletable, IAddressable, ISpatial, ILivable,
    ICollidable
{
    private Model? _model;

    /// <inheritdoc />
    public uint Handle { get; protected set; }

    /// <summary>
    /// Gets the model of this instance.
    /// </summary>
    /// <remarks>
    /// This property caches model so even if the entity invalidates, as long as this
    /// property were called as least once, the model can be still accessed.
    /// </remarks>
    public Model Model
    {
        get
        {
            _model ??= new Model((int)GetEntityModel(RequiresValid().Handle));

            return (Model)_model;
        }
    }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is visible (rendered by client).
    /// </summary>
    /// <value>
    /// <see langword="true"/> if this instance is visible; otherwise, <see langword="false"/>.
    /// </value>
    public bool Visible
    {
        get => IsEntityVisible(RequiresValid().Handle);
        set => SetEntityVisible(RequiresValid().Handle, value);
    }

    /// <summary>
    /// Gets a value indicating whether this instance is on fire.
    /// </summary>
    public bool IsOnFire => IsEntityOnFire(RequiresValid().Handle);

    /// <summary>
    /// Gets a value indicating whether this instance is on screen.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if this instance is between the two-dimensional space of the screen;
    /// otherwise <see langword="false"/>.
    /// </value>
    /// <remarks>
    /// This native returns <see langword="true"/> even if this instance is behind an obstacle. The value of
    /// this property should not be used to determine if the player even as least got any sight of this instance.
    /// </remarks>
    public bool IsOnScreen => IsEntityOnScreen(RequiresValid().Handle);

    /// <summary>
    /// Gets the speed of this instance.
    /// </summary>
    /// <value>
    /// A single-precision floating-point value representing the speed of this
    /// instance in meters per second.
    /// </value>
    public float Speed => GetEntitySpeed(RequiresValid().Handle);

    /// <summary>
    /// Gets a value indicating whether this instance is (partially) submerged by water.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if this instance is in water; otherwise, <see langword="false"/>.
    /// </value>
    public bool IsInWater => IsEntityInWater(RequiresValid().Handle);

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
    public bool IsLockedByGameEngine => IsEntityStatic(RequiresValid().Handle);

    /// <summary>
    /// Gets or sets the velocity of this instance.
    /// </summary>
    public Vector3 Velocity
    {
        get => GetEntityVelocity(RequiresValid().Handle);
        set => SetEntityVelocity(RequiresValid().Handle, value.X, value.Y, value.Z);
    }

    /// <summary>
    /// Gets a value indicating whether this instance is dead.
    /// </summary>
    public bool IsDead => IsEntityDead(RequiresValid().Handle);

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
        get => GetEntityHeading(RequiresValid().Handle);
        set
        {
            if (value is >= 360f or < 0f)
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
    public int CurrentInterior => GetInteriorFromEntity(RequiresValid().Handle);

    /// <inheritdoc />
    public IntPtr MemoryAddress => SHVDN.NativeMemory.GetEntityAddress((int)RequiresValid().Handle);

    /// <inheritdoc />
    public Vector3 Position
    {
        get => GetEntityCoords(RequiresValid().Handle, false);
        set => SetEntityCoords(RequiresValid().Handle, value.X, value.Y, value.Z, false, false, false, false);
    }

    /// <inheritdoc />
    public bool IsCollisionEnabled => GetEntityCollisionDisabled(RequiresValid().Handle);

    /// <summary>
    /// Gets a value indicating whether this instance is upside down.
    /// </summary>
    public bool IsUpsideDown => IsEntityUpsideDown(RequiresValid().Handle);

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