using System;
using GTA;

namespace WithLithum.Core.Exceptions
{
    /// <summary>
    /// Thrown when a method, constructor, operation or property that requires a valid <see cref="PoolObject"/> receives invalid <see cref="PoolObject"/>,
    /// or the object itself containing the property have it's handle invalidated.
    /// </summary>
    /// <remarks>
    /// <para><see cref="PoolObject"/>s have an unique identifier in the pool (a special <see cref="Array"/> used by RAGE Engine), consists of an <b>index</b> and a <b>counter</b>.
    /// When a handle no longer represents a valid object inside the pool, it will be considered invalid, which <see cref="PoolObject.Exists()"/> will return <see langword="false"/>.</para>
    /// <para>Note that this exception will not be thrown if the object was <see langword="null"/>; Instead, <see cref="NullReferenceException"/> or <see cref="ArgumentNullException"/> will be
    /// thrown.</para>
    /// </remarks>
    [Serializable]
    public class InvalidPoolObjectException : Exception
    {
        public InvalidPoolObjectException() { }
        public InvalidPoolObjectException(string message) : base(message) { }
        public InvalidPoolObjectException(PoolObject poolObject) : base($"The specified {poolObject.GetType().Name} was invalid.") { }
        public InvalidPoolObjectException(string message, Exception inner) : base(message, inner) { }
        protected InvalidPoolObjectException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
