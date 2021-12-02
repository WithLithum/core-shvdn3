using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static WithLithum.Core.Util.NativeFunctions;

namespace WithLithum.Core.Engine
{
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
    }
}
