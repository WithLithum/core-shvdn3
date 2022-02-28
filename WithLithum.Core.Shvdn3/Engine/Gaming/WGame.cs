﻿// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Engine.Gaming;

using JetBrains.Annotations;
using System;
using Util.Native;

/// <summary>
/// Provides methods and properties to manipulate aspects of the game.
/// Also provides utilities from the game engine.
/// </summary>
[PublicAPI]
public static class WGame
{
    /// <summary>
    /// Gets a value indicating whether the game is connected to Rockstar Games Social
    /// Club.
    /// </summary>
    /// <value>
    /// <see langword="true"/> if the game is online; otherwise, <see langword="false"/>.
    /// </value>
    public static bool IsOnline => Api.NetworkIsSignedOnline();

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
        return source.Length == 0 ? 0 : Api.GetHashKey(source);
    }

    /// <summary>
    /// Creates a restoration point for mission replay purposes.
    /// </summary>
    /// <returns><see langword="true"/> if the message is not on the screen.</returns>
    public static bool CreateRestorationPoint()
    {
        return Api.QueueMissionRepeatSave();
    }

    /// <summary>
    /// Loads the restoration point created by <see cref="CreateRestorationPoint()"/>.
    /// </summary>
    public static void LoadRestorationPoint()
    {
        Api.QueueMissionRepeatLoad();
    }

    /// <summary>
    /// Gets the amount of events currently being sent to scripts.
    /// </summary>
    /// <returns>The number of events.</returns>
    public static int GetNumberOfEvents()
    {
        return Api.GetNumberOfEvents();
    }
}