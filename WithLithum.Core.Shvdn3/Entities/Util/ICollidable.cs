namespace WithLithum.Core.Entities.Util;

using JetBrains.Annotations;

/// <summary>
/// Represents an instance that can be collided with.
/// </summary>
[PublicAPI]
public interface ICollidable
{
    /// <summary>
    /// Gets or sets whether this instance can be collided with.
    /// </summary>
    bool IsCollisionEnabled { get; set; }
}