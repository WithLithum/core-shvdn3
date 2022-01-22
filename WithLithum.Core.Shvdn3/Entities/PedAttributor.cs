namespace WithLithum.Core.Entities;

using GTA;
using System;
using Exceptions;
using Util.Native;
using JetBrains.Annotations;

/// <summary>
/// Represents some additions to the ped.
/// </summary>
[PublicAPI]
public class PedAttributor : EntityAttributor
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PedAttributor"/> class.
    /// </summary>
    /// <param name="value">The entity.</param>
    /// <exception cref="ArgumentNullException">The entity is null.</exception>
    /// <exception cref="ArgumentException">The entity is invalid.</exception>
    public PedAttributor(Ped value) : base(value)
    {
    }

    /// <summary>
    /// Blows the head of this instance.
    /// </summary>
    public void BlowHead()
    {
        Api.ExplodePedHead(RequiresValid().Handle, (uint)WeaponHash.Pistol);
    }
}
