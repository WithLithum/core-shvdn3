using GTA.Native;
using System;

namespace WithLithum.Core.Util
{
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

        /// <summary>
        /// <i>This is the wrapper for native function 0x7B1776B3B53F8D74.</i>
        /// </summary>
        /// <param name="entryLine1">The text label to display as the first line of the warning message.</param>
        /// <param name="instructionalKey">This is an enum, check the description for a list.</param>
        /// <param name="entryLine2">The text label to display as the second line of the warning</param>
        /// <param name="p3">Purpose unknown.</param>
        /// <param name="p4">Purpose unknown.</param>
        /// <param name="background">Set to anything other than 0 or false (even any string) and it will draw a background. Setting it to 0 or false will draw no background.</param>
        /// <param name="p6">Purpose unknown.</param>
        /// <param name="showBg">Purpose unknown.</param>
        /// <param name="errorCode">When not 0, adds a field displaying the value as 'error code' to the warning message.</param>
        public static void SetWarningMessage(string entryLine1, int instructionalKey, string entryLine2, bool p3, int p4, string background, string p6, bool showBg, int errorCode)
        {
            Function.Call(Hash.SET_WARNING_MESSAGE, entryLine1, instructionalKey, entryLine2, p3, p4, background, p6, showBg, errorCode);
        }
    }
}
