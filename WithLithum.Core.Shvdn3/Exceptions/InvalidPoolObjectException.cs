// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Exceptions;

using GTA;
using System;
using WithLithum.Core.Entities.Util;

/// <summary>
/// Thrown when a method, constructor, operation or property that requires a valid <see cref="PoolObject"/> receives invalid <see cref="PoolObject"/>,
/// or the object itself containing the property have it's handle invalidated.
/// </summary>
/// <remarks>
/// <para><see cref="PoolObject"/>s have an unique identifier in the pool (a special <see cref="Array"/> used by RAGE Engine), consists of an <b>index</b> and a <b>counter</b>.
/// When a handle no longer represents a valid object inside the pool, it will be considered invalid, which <see cref="PoolObject.Exists()"/> will return <see langword="false"/>.</para>
/// <para>Note that this exception will not be thrown if the object was <see langword="null"/>; Instead, <see cref="NullReferenceException"/> or <see cref="ArgumentNullException"/> will be
/// thrown.</para>
/// </remarks>
[Serializable]
public class InvalidPoolObjectException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidPoolObjectException"/> class.
    /// </summary>
    public InvalidPoolObjectException()
    { }

    /// <summary>Initializes a new instance of the <see cref="InvalidPoolObjectException"/> with specified message.</summary>
    /// <param name="message">The message which describes the exception.</param>
    public InvalidPoolObjectException(string message) : base(message) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidPoolObjectException"/> with the specified object.
    /// </summary>
    /// <param name="poolObject">The object.</param>
    public InvalidPoolObjectException(PoolObject poolObject) : base($"The specified {poolObject.GetType().Name} was invalid.") { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidPoolObjectException"/> with the specified object.
    /// </summary>
    /// <param name="poolObject">The object.</param>
    public InvalidPoolObjectException(IHandleable poolObject) : base($"The specified {poolObject.GetType().Name} was invalid.") { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidPoolObjectException"/>.
    /// </summary>
    /// <param name="message">The message which describes the exception.</param>
    /// <param name="inner">The inner exception.</param>
    public InvalidPoolObjectException(string message, Exception inner) : base(message, inner) { }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidPoolObjectException"/>.
    /// </summary>
    /// <param name="info">The information.</param>
    /// <param name="context">The context.</param>
    protected InvalidPoolObjectException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}