// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

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

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <returns><i>No description provided.</i></returns>
    public static bool CanCreateRandomDriver()
        => Function.Call<bool>(Hash.CAN_CREATE_RANDOM_DRIVER);

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <returns><i>No description provided.</i></returns>
    public static bool CanCreateRandomBikeRider()
        => Function.Call<bool>(Hash.CAN_CREATE_RANDOM_BIKE_RIDER);

    /// <summary>
    /// Forces the ped to fall back and kills it.
    /// </summary>
    /// <param name="ped"><i>No description provided.</i></param>
    /// <param name="weaponHash"><i>No description provided.</i></param>
    public static void ExplodePedHead(int /* Ped */ ped, uint weaponHash)
        => Function.Call(Hash.EXPLODE_PED_HEAD, ped, weaponHash);
}