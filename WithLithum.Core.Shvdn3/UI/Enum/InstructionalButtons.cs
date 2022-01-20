﻿// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.UI.Enum;

using JetBrains.Annotations;
using System;

/// <summary>
/// An enumeration of all possible instructional buttons. Mix them manually.
/// </summary>
[Flags]
[PublicAPI]
public enum InstructionalButtons
{
    /// <summary>
    /// No instructional buttons.
    /// </summary>
    None = 0,

    /// <summary>
    /// A "SELECT" button.
    /// </summary>
    Select = 1,

    /// <summary>
    /// An "OK" button.
    /// </summary>
    OK = 2,

    /// <summary>
    /// Yes button.
    /// </summary>
    Yes = 4,

    /// <summary>
    /// Back button.
    /// </summary>
    Back = 8,

    /// <summary>
    /// Cancel button.
    /// </summary>
    Cancel = 16,

    /// <summary>
    /// No button.
    /// </summary>
    No = 32,

    /// <summary>
    /// Retry button.
    /// </summary>
    Retry = 64,

    /// <summary>
    /// Skip button.
    /// </summary>
    Skip = 256,

    /// <summary>
    /// Continue button.
    /// </summary>
    Continue = 16384,

    /// <summary>
    /// Loading spinner.
    /// </summary>
    LoadingSpinner = 134217728,
}