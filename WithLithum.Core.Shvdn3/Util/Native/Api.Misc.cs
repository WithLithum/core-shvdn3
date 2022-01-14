namespace WithLithum.Core.Util.Native;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static partial class Api
{
    /// <summary>
    /// This native converts its past string to hash. It is hashed using
    /// jenkins one at a time method.
    /// </summary>
    /// <param name="text">The string to hash.</param>
    /// <returns>The hash of string.</returns>
    public static uint GetHashKey(string text) =>
        Function.Call<uint>(Hash.GET_HASH_KEY, text);

    /// <summary>
    /// Shows the screen which is visible before you redo a mission? The
    /// game will make a restoration point where you will cameback when
    /// the mission is over.
    /// </summary>
    /// <returns>Returns 1 if the message isn't currently on screen.</returns>
    public static bool QueueMissionRepeatSave() =>
        Function.Call<bool>(Hash.QUEUE_MISSION_REPEAT_SAVE);

    /// <summary>
    /// Sets the mission flag
    /// </summary>
    /// <param name="value">If true, the player can't save the game.
    /// If the parameter is true, sets the mission flag to true, if the
    /// parameter is false, the function does nothing at all.</param>
    public static void SetMissionFlag(bool value) =>
        Function.Call(Hash.SET_MISSION_FLAG, value);
}
