namespace WithLithum.Core.Entities;
using GTA;
using GTA.Math;
using System;
using WithLithum.Core.Exceptions;
using WithLithum.Core.Util.Native;

/// <summary>
/// Represents a vehicle.
/// </summary>
public class WVehicle : WEntity
{
    /// <summary>
    /// Initializes a new instance of the <see cref="WVehicle"/> class.
    /// </summary>
    /// <param name="model">The model of the vehicle.</param>
    /// <param name="position">The position of the vehicle.</param>
    /// <param name="heading">The heading.</param>
    public WVehicle(Model model, Vector3 position, float heading = 0)
    {
        this.Handle = (uint)World.CreateVehicle(model, position, heading).Handle;
    }

    /// <summary>
    /// Gets a value indicating whether this vehicle has it's engine on fire.
    /// </summary>
    /// <remarks>
    /// This property performs several checks based on vehicle engine health. To learn more,
    /// see the Vehicle Engine Health documentation.
    /// </remarks>
    public bool IsEngineOnFire
    {
        get
        {
            return Api.IsVehicleEngineOnFire(RequiresValid().Handle);
        }
    }

    /// <summary>
    /// Gets or sets the hit points remaining for the engine of this vehicle.
    /// </summary>
    /// <remarks>
    /// The hit points of an engine is between -4000 and 1000 (inclusive).
    /// <para>
    /// When the health of the engine is at <c>1000</c>, it's in perfect condition. When it drops below
    /// <c>300</c>, it will start to smoke.
    /// </para>
    /// <para>
    /// If the hit points are below <c>0</c>, it will catch on fire (when <see cref="IsEngineOnFire"/> will return <see langword="true"/>)
    /// , and after the fire is out, the engine will be unable to start and vulnerable to damages (it will catch on fire again on
    /// some damage).
    /// </para>
    /// <para>
    /// If the vehicle is destoryed, it will return <c>-4000</c>.
    /// </para>
    /// <para>
    /// If the hit points are just at <c>0</c> the engine will go out and unable to start, but it will not catch on fire.
    /// </para>
    /// </remarks>
    public float EngineHealth
    {
        get
        {
            return Api.GetVehicleEngineHealth(RequiresValid().Handle);
        }
        set
        {
            Api.SetVehicleEngineHealth(RequiresValid().Handle, value);
        }
    }

    /// <summary>
    /// Gets a value indicating whether is playback going on in this vehicle.
    /// </summary>
    public bool IsPlaybackGoingOn
    {
        get => Api.IsPlaybackGoingOnForVehicle(RequiresValid().Handle);
    }

    /// <summary>
    /// Sets the playback speed of this instance.
    /// </summary>
    /// <param name="value">The playback speed of this instance.</param>
    /// <example>
    /// An example of playback speed, in mission Chop:
    /// <code language="cs">
    /// trailer.SetPlaybackSpeed(trailerPlayback);
    /// </code>
    /// </example>
    public void SetPlaybackSpeed(float value)
    {
        Api.SetPlaybackSpeed(RequiresValid().Handle, value);
    }

    /// <summary>
    /// Sets whether this instance is not prone to crash damages.
    /// Please note that this does not make the vehicle collision proof.
    /// </summary>
    /// <param name="value">If set to <see langword="true"/>, this vehicle does not take damages from crashing.</param>
    public void SetNotProneToCrashDamage(bool value)
    {
        Api.SetVehicleStrong(RequiresValid().Handle, value);
    }

    /// <summary>
    /// Stops this vehicle, if on playback.
    /// </summary>
    /// <example>
    /// An example of playback speed, in mission Chop:
    /// <code language="cs">
    /// trailer.StopPlaybackRecorded()
    /// </code>
    /// </example>
    public void StopPlaybackRecorded()
    {
        Api.StopPlaybackRecordedVehicle(RequiresValid().Handle);
    }
}
