using GTA.Native;

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

        /// <summary>
        /// Adds an arbitrary string as a text component placeholder, replacing ~a~ in the current text command's text label.
        /// <br /><i>This is the wrapper for native function 0x6C188BE134E074AA.</i>
        /// </summary>
        /// <param name="text">The text to add.</param>
        public static void AddTextComponentSubstringPlayerName(string text) => Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, text);

        /// <summary>
        /// Adds a text label as a text component placeholder, replacing ~a~ in the current text command's text label.
        /// <br /><i>This is the wrapper for native function 0xC63CD5D2920ACBE7.</i>
        /// </summary>
        /// <param name="text">The text to add.</param>
        public static void AddTextComponentSubstringTextLabel(string text) => Function.Call(Hash.ADD_TEXT_COMPONENT_SUBSTRING_PLAYER_NAME, text);

        /// <summary>
        /// Initializes the text entry for the text next to a loading prompt.
        /// All natives for building UI texts can be used here .
        /// <br /><i>This is the wrapper for native function 0xABA17D7CE615ADBF.</i>
        /// </summary>
        /// <param name="str">The text to add.</param>
        public static void BeginTextCommandBusyspinnerOn(string str) => Function.Call(Hash.BEGIN_TEXT_COMMAND_BUSYSPINNER_ON, str);

        /// <summary>
        /// <i>This is the wrapper for native function 0xBD12F8228410D9B4.</i>
        /// </summary>
        /// <param name="busySpinnerType">The type of the spinner.</param>
        public static void EndTextCommandBusyspinnerOn(int busySpinnerType) => Function.Call(Hash.END_TEXT_COMMAND_BUSYSPINNER_ON, busySpinnerType);

        /// <summary>
        /// <i>This is the wrapper for native function 0xD422FCC5F239A915.</i>
        /// </summary>
        public static bool BusyspinnerIsOn() => Function.Call<bool>(Hash.BUSYSPINNER_IS_ON);
    }
}
