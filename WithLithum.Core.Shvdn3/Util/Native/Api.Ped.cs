namespace WithLithum.Core.Util.Native;

using GTA.Native;

public static partial class Api
{
    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="multiplier"><i>No description provided.</i></param>
    public static void SetPedDensityMultiplierThisFrame(float multiplier)
        => Function.Call(Hash.SET_PED_DENSITY_MULTIPLIER_THIS_FRAME, multiplier);
}
