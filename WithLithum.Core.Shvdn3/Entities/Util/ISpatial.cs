namespace WithLithum.Core.Entities.Util;
using GTA.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Represents an entity that is locatable.
/// </summary>
public interface ISpatial
{
    /// <summary>
    /// Gets or sets the position of this instance.
    /// </summary>
    Vector3 Position { get; set; }
}
