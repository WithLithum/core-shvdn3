// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Engine;

using JetBrains.Annotations;
using Util.Native;

/// <summary>
/// Provides utilities to manipulate scripting.
/// </summary>
[PublicAPI]
public static class ThreadUtil
{
    /// <summary>
    /// Determines whether the forced cleanup of the specified type has occured.
    /// </summary>
    /// <param name="flags">The type of the cleanup.</param>
    /// <returns><see langword="true"/> if the specified cleanup occured; otherwise, <see langword="false"/>.</returns>
    public static bool HasForcedCleanupOccured(int flags) => Api.HasForceCleanupOccurred(flags);
}