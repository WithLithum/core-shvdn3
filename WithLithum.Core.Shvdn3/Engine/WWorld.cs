namespace WithLithum.Core.Engine;
using GTA.Math;
using JetBrains.Annotations;
using WithLithum.Core.Util.Native;

/// <summary>
/// Provides utilities to manipulate world.
/// </summary>
[PublicAPI]
public static class WWorld
{
    /// <summary>
    /// Loads a scene to the world.
    /// </summary>
    /// <param name="vector">The position to load the scene.</param>
    public static void LoadScene(Vector3 vector)
    {
        Api.LoadScene(vector.X, vector.Y, vector.Z);
    }

    /// <summary>
    /// Sets the random vehicle density in the current tick.
    /// </summary>
    /// <remarks>
    /// This is a ticked function. You must call this each tick.
    /// </remarks>
    /// <param name="density">The density to set.</param>
    public static void SetTickRandomVehicleDensity(float density)
    {
        Api.SetRandomVehicleDensityThisFrame(density);
    }

    /// <summary>
    /// Sets the density multiplier of the parked vehicles to the specified
    /// value.
    /// </summary>
    /// <remarks>
    /// This is a ticked function. You must call this each tick.
    /// </remarks>
    /// <param name="density">The density to set.</param>
    public static void SetTickParkedVehicleDensity(float density)
    {
        Api.SetParkedVehicleDensityThisFrame(density);
    }

    /// <summary>
    /// Sets the range multiplier of the ambient vehicles to the specified
    /// value, effective for the current tick.
    /// </summary>
    /// <param name="range">The range multiplier.</param>
    public static void SetTickVehicleRangeMultiplier(float range)
    {
        Api.SetAmbientVehicleRangeMultiplierThisFrame(range);
    }

    /// <summary>
    /// Sets the ped density multiplier of the ambient peds to the specified
    /// value, effective for the current tick.
    /// </summary>
    /// <param name="multiplier">The multiplier.</param>
    public static void SetTickPedDensity(float multiplier)
    {
        Api.SetPedDensityMultiplierThisFrame(multiplier);
    }
}
