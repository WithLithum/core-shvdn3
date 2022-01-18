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
}