namespace WithLithum.Core.Entities;
using GTA.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ISpatial
{
    /// <summary>
    /// Gets or sets the position of this instance.
    /// </summary>
    Vector3 Position { get; set; }
}
