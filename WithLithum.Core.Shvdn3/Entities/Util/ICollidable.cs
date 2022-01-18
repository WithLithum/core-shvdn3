namespace WithLithum.Core.Entities.Util;

/// <summary>
/// Represents an instance that can be collided with.
/// </summary>
public interface ICollidable
{
    /// <summary>
    /// Gets or sets whether this instance can be collided with.
    /// </summary>
    bool IsCollisionEnabled { get; }
}