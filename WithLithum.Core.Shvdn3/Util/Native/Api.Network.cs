// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Util.Native;

using GTA.Native;

/// <summary>
/// Provides wrappers for native functions.
/// </summary>
public static partial class Api
{
    /// <summary>
    /// Determines whether the current session is a solo session.
    /// </summary>
    /// <returns><c>true</c> if it is a solo session; otherwise, <c>false</c>.</returns>
    public static bool NetworkSessionIsSolo()
    {
        return Function.Call<bool>(Hash.NETWORK_SESSION_IS_SOLO);
    }

    /// <summary>
    /// Determines whether the current session is a closed session.
    /// </summary>
    /// <returns><c>true</c> if this session is closed; otherwise, <c>false</c>.</returns>
    public static bool NetworkSessionIsPrivate()
    {
        return Function.Call<bool>(Hash.NETWORK_SESSION_IS_PRIVATE);
    }


    /// <summary>
    /// Returns whether the game is not in offline mode.
    /// </summary>
    /// <returns>Returns whether the game is not in offline mode.</returns>
    public static bool NetworkIsSignedOnline()
    {
        return Function.Call<bool>(Hash.NETWORK_IS_SIGNED_ONLINE);
    }
}