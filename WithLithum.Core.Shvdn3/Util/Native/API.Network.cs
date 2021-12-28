using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.Util.Native
{
    /// <summary>
    /// Provides wrappers for native functions.
    /// </summary>
    public static partial class Api
    {
        /// <summary>
        /// Determines whether the current session is a solo session.
        /// </summary>
        /// <returns><c>true</c> if it is a solo session; otherwise, <c>false</c>.</returns>
        public static bool NetworkSessionIsSolo()
        {
            return Function.Call<bool>(Hash.NETWORK_SESSION_IS_SOLO);
        }

        /// <summary>
        /// Determines whether the current session is a closed session.
        /// </summary>
        /// <returns><c>true</c> if this session is closed; otherwise, <c>false</c>.</returns>
        public static bool NetworkSessionIsPrivate()
        {
            return Function.Call<bool>(Hash.NETWORK_SESSION_IS_PRIVATE);
        }
    }
}
