// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.UI.Hud;

using JetBrains.Annotations;
using WithLithum.Core.Util.Native;

/// <summary>
/// Provides utilities to manipulate the loading spinner.
/// </summary>
[PublicAPI]
public static class BusySpinner
{
    /// <summary>
    /// Gets a value indicating whether the busy spinner is currently active.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if busy spinner is currently active; otherwise, <see langword="false"/>.
    /// </value>
    public static bool IsBusySpinnerActive => Api.BusyspinnerIsOn();

    /// <summary>
    /// Displays the busy spinner.
    /// </summary>
    /// <param name="text">The text to display.</param>
    /// <param name="type">The type of the spinner.</param>
    public static void DisplayBusySpinner(Text text, BusySpinnerType type = BusySpinnerType.Right)
    {
        Api.BeginTextCommandBusyspinnerOn("STRING");
        text.Add();
        Api.EndTextCommandBusyspinnerOn((int)type);
    }
}