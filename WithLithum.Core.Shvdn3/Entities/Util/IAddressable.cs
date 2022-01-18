// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities.Util;

using System;

/// <summary>
/// Represents an object that has a memory address.
/// </summary>
public interface IAddressable
{
    /// <summary>
    /// Gets the memory address of this instance.
    /// </summary>
    IntPtr MemoryAddress { get; }
}