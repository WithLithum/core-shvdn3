namespace WithLithum.Core.Entities.Util;

using JetBrains.Annotations;

/// <summary>
/// Represents an object that can be persistent.
/// </summary>
[PublicAPI]
public interface IPersistable
{
    /// <summary>
    /// Gets or sets a value indicating whether the game engine will refrain
    /// from removing this entity.
    /// </summary>
    bool IsPersistent { get; set; }

    /// <summary>
    /// Dismisses this instance, if previously the game engine was told to
    /// refrain from deleting this instance on it's own.
    /// </summary>
    void Dismiss();
}