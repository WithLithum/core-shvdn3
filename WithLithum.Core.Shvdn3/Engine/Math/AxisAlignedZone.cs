using GTA.Math;
using JetBrains.Annotations;

namespace WithLithum.Core.Engine.Math;

/// <summary>
/// Represents a zone that is marked out by two aligned corners.
/// </summary>
[PublicAPI]
public struct AxisAlignedZone
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AxisAlignedZone"/> struct.
    /// </summary>
    /// <param name="x">The first corner.</param>
    /// <param name="y">The second corner.</param>
    public AxisAlignedZone(Vector3 x, Vector3 y)
    {
        CornerX = x;
        CornerY = y;
    }
    
    /// <summary>
    /// Gets or sets the first corner of this instance.
    /// </summary>
    public Vector3 CornerX { get; set; }
    
    /// <summary>
    /// Gets or sets the second corner of this instance.
    /// </summary>
    public Vector3 CornerY { get; set; }
}