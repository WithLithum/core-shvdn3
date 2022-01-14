namespace WithLithum.Core.Engine;

using static WithLithum.Core.Util.NativeFunctions;
using static WithLithum.Core.Util.Native.Api;

/// <summary>
/// Provides utilties to manipulate various session-related stuff in single/multi-player.
/// Not intended for GTA Online.
/// </summary>
public static class Session
{
    /// <summary>
    /// Gets the numbers of the players in the current session.
    /// </summary>
    /// <value>
    /// If in multiplayer, the number of players in the current session; otherwise, always <c>1</c>.
    /// </value>
    public static int PlayerCount => GetNumberOfPlayers();

    /// <summary>
    /// Gets a value indicating whether this client is in a solo session.
    /// </summary>
    /// <value>
    /// <c>true</c> if this session is a solo session; otherwise, <c>false</c>.
    /// </value>
    public static bool IsSolo => NetworkSessionIsSolo();

    /// <summary>
    /// Gets a value indicating whether this client is in a closed session.
    /// </summary>
    /// <value>
    /// <c>true</c> if this session is closed; otherwise, <c>false</c>.
    /// </value>
    public static bool IsClosed => NetworkSessionIsPrivate();
}
