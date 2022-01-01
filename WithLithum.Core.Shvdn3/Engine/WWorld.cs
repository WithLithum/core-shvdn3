using GTA.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util.Native;

namespace WithLithum.Core.Engine
{
    /// <summary>
    /// Provides utilties to manipulate world.
    /// </summary>
    public static class WWorld
    {
        /// <summary>
        /// Loads a scene to the world.
        /// </summary>
        /// <param name="vector">The position to load the scene.</param>
        public static void LoadScene(Vector3 vector)
        {
            Api.LoadScene(vector.X, vector.Y, vector.Z);
        }
    }
}
