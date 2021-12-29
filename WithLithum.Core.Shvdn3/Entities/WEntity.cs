using WithLithum.Core.Exceptions;
using static WithLithum.Core.Util.Native.Api;

namespace WithLithum.Core.Entities
{
    /// <summary>
    /// Represents an entity in the game world.
    /// </summary>
    public abstract class WEntity : IHandleable
    {
        /// <inheritdoc />
        public uint Handle { get; protected set; }

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
    }
}
