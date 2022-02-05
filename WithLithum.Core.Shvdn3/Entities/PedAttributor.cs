namespace WithLithum.Core.Entities;

using GTA;
using JetBrains.Annotations;
using System;
using Util.Native;

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
    /// Gets a value indicating whether the ringtone of this instance is playing.
    /// </summary>
    public bool IsRingtonePlaying => Api.IsPedRingtonePlaying(this.RequiresValid().Handle);

    /// <summary>
    /// Plays the ringtone of this instance.
    /// </summary>
    /// <param name="ringtone">The ringtone to play. Usually <c>Remote_Ring</c>, or <c>Dial_and_Remote_Ring</c>.</param>
    public void PlayRingtone(string ringtone)
    {
        Api.PlayPedRingtone(ringtone, RequiresValid().Handle, true);
    }

    /// <summary>
    /// Blows the head of this instance.
    /// </summary>
    public void BlowHead()
    {
        Api.ExplodePedHead(RequiresValid().Handle, (uint)WeaponHash.Pistol);
    }

    /// <summary>
    /// Stops the ringtone being played on this instance.
    /// </summary>
    public void StopRingtone()
    {
        Api.StopPedRingtone(RequiresValid().Handle);
    }
}