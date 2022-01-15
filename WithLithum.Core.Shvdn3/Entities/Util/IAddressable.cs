namespace WithLithum.Core.Entities.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
