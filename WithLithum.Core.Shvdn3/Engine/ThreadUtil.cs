namespace WithLithum.Core.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util.Native;

/// <summary>
/// Provides utilties to manipulate scripting.
/// </summary>
public static class ThreadUtil
{
    /// <summary>
    /// Determines whether the forced cleanup of the specified type has occured.
    /// </summary>
    /// <param name="flags">The type of the cleanup.</param>
    /// <returns><see langword="true"/> if the specified cleanup occured; otherwise, <see langword="false"/>.</returns>
    public static bool HasForcedCleanupOccured(int flags) => Api.HasForceCleanupOccurred(flags);
}
