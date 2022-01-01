using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.Util.Native
{
    public static partial class Api
    {
        /// <summary>
        /// <i>No description provided.</i>
        /// </summary>
        /// <param name="cleanupFlags"><i>No description provided.</i></param>
        /// <returns><i>No description provided.</i></returns>
        public static bool HasForceCleanupOccurred(int cleanupFlags) => Function.Call<bool>(Hash.HAS_FORCE_CLEANUP_OCCURRED, cleanupFlags);
    }
}
