namespace WithLithum.Core.Entities;
using GTA.Math;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util.Native;

/// <summary>
/// Represents a checkpoint.
/// </summary>
public class Checkpoint : IDeletable
{
    /// <summary>
    /// An enumeration of all possible styles of the checkpoint.
    /// </summary>
    public enum Style
    {
        /// <summary>
        /// <see cref="BaleCylinder"/> with an arrow.
        /// </summary>
        CylinderOneArrow,
        /// <summary>
        /// <see cref="BaleCylinder"/> with two arrows.
        /// </summary>
        CylinderTwoArrows,
        /// <summary>
        /// <see cref="BaleCylinder"/> with three arrows.
        /// </summary>
        CylinderThreeArrows,
        /// <summary>
        /// <see cref="BaleCylinder"/> with an arrow of cycle.
        /// </summary>
        CylinderCycleArrow,
        /// <summary>
        /// <see cref="BaleCylinder"/> with a win flag.
        /// </summary>
        CylinderWinFlag,
        /// <summary>
        /// <see cref="BaleCylinder"/> with a wrench.
        /// </summary>
        CylinderWrench,
        /// <summary>
        /// <see cref="BaleCircle"/> with an arrow.
        /// </summary>
        CircleOneArrow = 12,
        /// <summary>
        /// <see cref="BaleCircle"/> with two arrows.
        /// </summary>
        CircleTwoArrows,
        /// <summary>
        /// <see cref="BaleCircle"/> with three arrows.
        /// </summary>
        CircleThreeArrows,
        /// <summary>
        /// <see cref="BaleCircle"/> with an arrow of cycle.
        /// </summary>
        CircleCycleArrow,
        /// <summary>
        /// <see cref="BaleCircle"/> with a win flag.
        /// </summary>
        CircleWinFlag,
        /// <summary>
        /// An arrow.
        /// </summary>
        BaleOneArrow,
        /// <summary>
        /// Two arrows.
        /// </summary>
        BaleTwoArrows,
        /// <summary>
        /// Three arrows.
        /// </summary>
        BaleThreeArrows,
        /// <summary>
        /// An arrow of circle.
        /// </summary>
        BaleCycleArrow,
        /// <summary>
        /// A win flag.
        /// </summary>
        BaleWinFlag,
        /// <summary>
        /// <see cref="BaleCircle"/> with an icon of a plane leveled off.
        /// </summary>
        /// <summary>
        /// <see cref="BaleCircle"/> with an icon of a plane rolled to left.
        /// </summary>
        PlaneRollLeft,
        /// <summary>
        /// <see cref="BaleCircle"/> with an icon of a plane rolled to right.
        /// </summary>
        PlaneRollRight,
        /// <summary>
        /// <see cref="BaleCircle"/> with an icon of a plane rolled upside down.
        /// </summary>
        PlaneRollUpsideDown,
        /// <summary>
        /// Nothing but a circle.
        /// </summary>
        BaleCircle = 42,
        /// <summary>
        /// <see cref="BaleCylinder"/> with a number.
        /// </summary>
        /// <remarks>
        /// <note type="warning">
        /// You must use <see cref="Checkpoint.Checkpoint(Vector3, Color, Style, float, Vector3, int)"/> otherwise it will not work.
        /// </note>
        /// </remarks>
        CylinderNumber = 44,
        BaleCylinder = 47
    }

    public Checkpoint(Vector3 position, Color color, float scale) : this(position, color, Style.BaleCylinder, scale)
    {
    }

    public Checkpoint(Vector3 position, Color color, Style style, float scale) : this(position, color, style, scale, Vector3.Zero)
    {
    }

    public Checkpoint(Vector3 position, Color color, Style style, float scale, Vector3 arrowTarget) : this(position, color, style, scale, arrowTarget, 0)
    {
    }

    public Checkpoint(Vector3 position, Color color, Style style, float scale, Vector3 arrowTarget, int number)
    {
        Handle = Api.CreateCheckpoint((int)style, position.X, position.Y, position.Z, arrowTarget.X, arrowTarget.Y, arrowTarget.Z, scale, color.R, color.G, color.B, color.A, number);
    }

    public int Handle { get; }

    public void Delete()
    {
        Api.DeleteCheckpoint(Handle);
    }
}
