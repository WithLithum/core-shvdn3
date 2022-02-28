// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Util.Native;

using GTA.Native;

public static partial class Api
{
    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="cleanupFlags"><i>No description provided.</i></param>
    /// <returns><i>No description provided.</i></returns>
    public static bool HasForceCleanupOccurred(int cleanupFlags) => Function.Call<bool>(Hash.HAS_FORCE_CLEANUP_OCCURRED, cleanupFlags);

    /// <summary>
    /// Gets the number of players in the current session.<br />
    /// <i>This is the wrapper for native function 0x407C7F91DDB46C16.</i>
    /// </summary>
    /// <returns>If in multiplayer, the number of players in the current session; otherwise, always <c>1</c>.</returns>
    public static int GetNumberOfPlayers() => Function.Call<int>(Hash.GET_NUMBER_OF_PLAYERS);
}