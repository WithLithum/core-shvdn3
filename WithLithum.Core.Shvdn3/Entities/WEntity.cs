using GTA;
using System;
using System.ComponentModel;
using WithLithum.Core.Exceptions;
using static WithLithum.Core.Util.Native.Api;

namespace WithLithum.Core.Entities
{
    /// <summary>
    /// Represents an entity in the game world.
    /// </summary>
    public abstract class WEntity : IHandleable, IDeletable
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
    }
}
