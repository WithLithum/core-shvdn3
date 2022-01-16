namespace WithLithum.Core.Entities.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents a entity that can be living.
/// </summary>
public interface ILivable
{
    /// <summary>
    /// Gets a value indicating whether this instance is currently alive.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if this instance is alive; otherwise, <see langword="false"/>.
    /// </value>
    bool IsAlive { get; }

    /// <summary>
    /// Gets a value indicating whether this instance is currently dead.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if this instance is dead; otherwise, <see langword="false"/>.
    /// </value>
    bool IsDead { get; }

    /// <summary>
    /// Gets the remaining hit points for this instance.
    /// </summary>
    int Health { get; set; }

    /// <summary>
    /// Gets the maximum hit points available for this instance.
    /// </summary>
    int MaxHealth { get; set; }

    /// <summary>
    /// Kills this instance.
    /// </summary>
    /// <remarks>
    /// Killing instances may not have any effect at all, depending on the type of the entity.
    /// For example, peds collapse and die when it is being killed, but props and vehicles may
    /// not have any effect at all.
    /// </remarks>
    void Kill();
}
