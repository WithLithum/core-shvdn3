namespace WithLithum.Core.Util.Native;

using GTA.Native;

public static partial class Api
{
    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="ped"><i>No description provided.</i></param>
    /// <returns><i>No description provided.</i></returns>
    public static float GetPedDesiredMoveBlendRatio(int /* Ped */ ped)
        => Function.Call<float>(Hash.GET_PED_DESIRED_MOVE_BLEND_RATIO, ped);
}