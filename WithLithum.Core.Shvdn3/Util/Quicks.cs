// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Util;

using GTA;

/// <summary>
/// Provide quick accesses. This class is meant to be imported using <c>using static</c>.
/// </summary>
public static class Quicks
{
    /// <summary>
    /// Gets the player character.
    /// </summary>
    /// <value>
    /// The player character.
    /// </value>
    public static Ped PChara => Game.Player.Character;

    /// <summary>
    /// Gets the player's current vehicle.
    /// </summary>
    /// <value>
    /// If player's in vehicle, player's current vehicle; otherwise, <c>null</c>.
    /// </value>
    public static Vehicle PVehicle => Game.Player.Character.CurrentVehicle;
}