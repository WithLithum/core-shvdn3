namespace WithLithum.Core.Entities;
using GTA;
using GTA.Math;
using System;
using Util;
using Exceptions;
using JetBrains.Annotations;
using static WithLithum.Core.Util.Native.Api;
using IDeletable = Util.IDeletable;
using ISpatial = Util.ISpatial;

/// <summary>
/// Represents an entity in the game world.
/// </summary>
[PublicAPI]
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
            _model ??= new Model((int) GET_ENTITY_MODEL(RequiresValid().Handle));

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
        get => IS_ENTITY_VISIBLE(RequiresValid().Handle);
        set => SET_ENTITY_VISIBLE(RequiresValid().Handle, value, false);
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
    public bool IsOnScreen => IS_ENTITY_ON_SCREEN(RequiresValid().Handle);

    /// <summary>
    /// Gets the speed of this instance.
    /// </summary>
    /// <value>
    /// A single-precision floating-point value representing the speed of this
    /// instance in meters per second.
    /// </value>
    public float Speed => GET_ENTITY_SPEED(RequiresValid().Handle);

    /// <summary>
    /// Gets a value indicating whether this instance is (partially) submerged by water.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if this instance is in water; otherwise, <see langword="false"/>.
    /// </value>
    public bool IsInWater => IS_ENTITY_IN_WATER(RequiresValid().Handle);

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
    public bool IsLockedByGameEngine => IS_ENTITY_STATIC(RequiresValid().Handle);

    /// <summary>
    /// Gets or sets the velocity of this instance.
    /// </summary>
    public Vector3 Velocity
    {
        get => GET_ENTITY_VELOCITY(RequiresValid().Handle);
        set => SET_ENTITY_VELOCITY(RequiresValid().Handle, value.X, value.Y, value.Z);
    }

    /// <summary>
    /// Gets a value indicating whether this instance is dead.
    /// </summary>
    public bool IsDead => IS_ENTITY_DEAD(RequiresValid().Handle, false);

    /// <summary>
    /// Gets a value indicating whether this instance is in the air.
    /// </summary>
    public bool IsInAir => IS_ENTITY_IN_AIR(RequiresValid().Handle);
    
    /// <summary>
    /// Gets a value indicating whether this instance is alive.
    /// </summary>
    public bool IsAlive => !IsDead;

    /// <inheritdoc />
    public int Health
    {
        get => GET_ENTITY_HEALTH(RequiresValid().Handle);
        set => SET_ENTITY_HEALTH(RequiresValid().Handle, value, 0);
    }

    /// <inheritdoc/>
    public int MaxHealth
    {
        get => GET_ENTITY_MAX_HEALTH(RequiresValid().Handle);
        set => SET_ENTITY_MAX_HEALTH(RequiresValid().Handle, value);
    }

    /// <summary>
    /// Gets or sets the heading of the instance.
    /// </summary>
    /// <value>
    /// A <see cref="float"/> value, ranged in <c>0</c> to <c>359+</c>, representing the heading of this instance.
    /// </value>
    public float Heading
    {
        get => GET_ENTITY_HEADING(RequiresValid().Handle);
        set
        {
            if (value is >= 360f or < 0f)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Heading must be in degrees (0f-359.99999+f).");
            }

            SET_ENTITY_HEADING(RequiresValid().Handle, value);
        }
    }

    /// <inheritdoc />
    public IntPtr MemoryAddress => SHVDN.NativeMemory.GetEntityAddress((int)RequiresValid().Handle);

    /// <inheritdoc />
    public Vector3 Position
    {
        get => GET_ENTITY_COORDS(RequiresValid().Handle, false);
        set => SET_ENTITY_COORDS(RequiresValid().Handle, value.X, value.Y, value.Z, false, false, false, false);
    }


    /// <inheritdoc />
    public bool IsCollisionEnabled
    {
        get => !GET_ENTITY_COLLISION_DISABLED(RequiresValid().Handle);
        set => SET_ENTITY_COLLISION(RequiresValid().Handle, value, value);
    }

    /// <summary>
    /// Gets a value indicating whether this instance is upside down.
    /// </summary>
    public bool IsUpsideDown => IS_ENTITY_UPSIDEDOWN(RequiresValid().Handle);

    /// <summary>
    /// Sets a value indicating whether the light of this entity is on.
    /// </summary>
    /// <param name="on">On or off.</param>
    public void SetLightsOn(bool on)
    {
        SET_ENTITY_LIGHTS(RequiresValid().Handle, !on);
    }

    /// <inheritdoc />
    public void Delete()
    {
        var handle = RequiresValid().Handle;
        DELETE_ENTITY(ref handle);
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
        APPLY_FORCE_TO_ENTITY(RequiresValid().Handle, (int)type, pos.X, pos.Y, pos.Z, offset.X, offset.Y, offset.Z, 0, isDirectionalRel, false, isForceRel, false, true);
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
        return DOES_ENTITY_EXIST(Handle);
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
