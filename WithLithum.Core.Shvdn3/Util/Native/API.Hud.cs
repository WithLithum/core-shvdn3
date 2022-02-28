// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Util.Native;

using GTA.Math;
using GTA.Native;

public static partial class Api
{
    /// <summary>
    /// <br /><i>This is the wrapper for native function 0xB0034A223497FFCB.</i>
    /// </summary>
    public static bool IsPauseMenuActive() => Function.Call<bool>(Hash.IS_PAUSE_MENU_ACTIVE);

    /// <summary>
    /// <br /><i>This is the wrapper for native function 0xDF47FC56C71569CF.</i>
    /// </summary>
    public static void SetPauseMenuActive(bool toggle) => Function.Call(Hash.SET_PAUSE_MENU_ACTIVE, toggle);

    /// <summary>
    /// <br /><i>This is the wrapper for native function 0x5BFF36D6ED83E0AE.</i>
    /// </summary>
    /// <returns>If the pause menu is open, it will return a Vector3, Z is always 0. If the pause menu is closed, it will return Vector3.Zero</returns>
    public static Vector3 GetPauseMenuCursorPosition()
    {
        return Function.Call<Vector3>((Hash)0x5BFF36D6ED83E0AE);
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