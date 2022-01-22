namespace WithLithum.Core.Entities;

using GTA;
using System;
using System.Collections.Generic;
using WithLithum.Core.Exceptions;

/// <summary>
/// Provides extensions methods to the <see cref="Entity"/> class.
/// </summary>
public static class EntityExtensions
{
    private static readonly Dictionary<Entity, EntityAttributor> _attributors = new();

    /// <summary>
    /// Receives an instance of <see cref="EntityAttributor"/>.
    /// </summary>
    /// <param name="e">The entity.</param>
    /// <returns>An instance of <see cref="EntityAttributor"/>.</returns>
    /// <exception cref="ArgumentNullException">The entity was null.</exception>
    /// <exception cref="InvalidPoolObjectException">The entity was invalid.</exception>
    public static EntityAttributor Attributor(Entity e)
    {
        if (e == null)
        {
            _attributors.Remove(e);
            throw new ArgumentNullException(nameof(e));
        }

        if (!e.Exists())
        {
            _attributors.Remove(e);
            throw new InvalidPoolObjectException(e);
        }

        if (!_attributors.ContainsKey(e))
        {
            _attributors[e] = new EntityAttributor(e);
        }

        return _attributors[e];
    }
}