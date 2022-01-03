using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util.Native;

namespace WithLithum.Core.Engine.Gaming
{
    /// <summary>
    /// Provides methods and properties to manipulate aspects of the game.
    /// Also provides utilties from the game engine.
    /// </summary>
    public static class WGame
    {
        /// <summary>
        /// Calculates Jenkins-One-At-A-Time hash based on the <paramref name="source"/> string.
        /// The hash is not case sensitive.
        /// </summary>
        /// <param name="source">The input string.</param>
        /// <returns>The hash calculated. Same results for uppercase and lowercase.</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static uint GetHashKey(string source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (source.Length == 0) return 0;

            return Api.GetHashKey(source);
        }

        /// <summary>
        /// Creates a restoration point for mission replay purposes.
        /// </summary>
        /// <returns><see langword="true"/> if the message is not on the screen.</returns>
        public static bool CreateRestorationPoint()
        {
            return Api.QueueMissionRepeatSave();
        }
    }
}
