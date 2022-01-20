// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Util;

using GTA.Native;
using System;

/// <summary>
/// Provides quick access for most natives being used in this library as well as other intresting natives.
/// </summary>
[Obsolete("Move to Native Api instead. If there are still natives using this, migrate to API.")]
public static class NativeFunctions
{
    /// <summary>
    /// Gets the number of players in the current session.<br />
    /// <i>This is the wrapper for native function 0x407C7F91DDB46C16.</i>
    /// </summary>
    /// <returns>If in multiplayer, the number of players in the current session; otherwise, always <c>1</c>.</returns>
    public static int GetNumberOfPlayers() => Function.Call<int>(Hash.GET_NUMBER_OF_PLAYERS);
}