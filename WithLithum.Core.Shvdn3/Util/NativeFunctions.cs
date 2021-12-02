using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.Util
{
    /// <summary>
    /// Provides quick access for most natives being used in this library as well as other intresting natives.
    /// </summary>
    public static class NativeFunctions
    {
        /// <summary>
        /// Gets the number of players in the current session.<br />
        /// <i>This is the wrapper for native function 0x407C7F91DDB46C16.</i>
        /// </summary>
        /// <returns>If in multiplayer, the number of players in the current session; otherwise, always <c>1</c>.</returns>
        public static int GetNumberOfPlayers() => Function.Call<int>(Hash.GET_NUMBER_OF_PLAYERS);

        /// <summary>
        /// this enables or disables lights on things such as objects.<br />
        /// <i>This is the wrapper for native function 0x7CFBA6A80BDF3874.</i>
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="toggle">when toggle is set to true it turns off the lights, when false it turns them on.</param>
        public static void SetEntityLights(int entity, bool toggle) => Function.Call(Hash.SET_ENTITY_LIGHTS, entity, toggle);
    }
}
