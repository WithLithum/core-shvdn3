namespace WithLithum.Core.Entities;

using GTA;
using System;
using Attributing;
using Exceptions;
using Util.Native;
using JetBrains.Annotations;

/// <summary>
/// Represents some additions to the ped.
/// </summary>
[PublicAPI]
public class PedAttributor : IAttributor<Ped>
{
    private Ped _internal;

    static PedAttributor()
    {
        AttributorManager.RegisterAttributor<Ped, EntityAttributor>();
    }

    /// <summary>
    /// Initializes this instance.
    /// </summary>
    public static void Init()
    {
        // null-sub to trigger the static
    }

    /// <inheritdoc />
    public void Apply(Ped value)
    {
        if (value == null) throw new ArgumentNullException(nameof(value));
        if (!value.Exists()) throw new ArgumentException("Invalid value", nameof(value));

        _internal = value;
    }

    private Ped RequiresValid()
    {
        if (_internal?.Exists() != true) throw new InvalidPoolObjectException("Invalid internal!");
        return _internal;
    }

    /// <summary>
    /// Blows the head of this instance.
    /// </summary>
    public void BlowHead()
    {
        Api.ExplodePedHead(RequiresValid().Handle, (uint)WeaponHash.Pistol);
    }
}
