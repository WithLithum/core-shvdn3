// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Util.Native;

using GTA.Native;
using JetBrains.Annotations;

[PublicAPI]
public static partial class Api
{
    /// <summary>
    /// This native converts its past string to hash. It is hashed using
    /// Jenkins-One-At-A-Time method.
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

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <returns><i>No description provided.</i></returns>
    public static bool QueueMissionRepeatLoad() =>
        Function.Call<bool>(Hash.QUEUE_MISSION_REPEAT_LOAD);
}