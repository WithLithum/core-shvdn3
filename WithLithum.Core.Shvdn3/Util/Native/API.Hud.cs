using GTA.Math;
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
        /// <br /><i>This is the wrapper for native function 0xB0034A223497FFCB.</i>
        /// </summary>
        public static bool IsPauseMenuActive() => Function.Call<bool>(Hash.IS_PAUSE_MENU_ACTIVE);

        /// <summary>
        /// <br /><i>This is the wrapper for native function 0xDF47FC56C71569CF.</i>
        /// </summary>
        public static void SetPauseMenuActive(bool toggle) => Function.Call(Hash.SET_PAUSE_MENU_ACTIVE, toggle);

        /// <summary>
        /// <br /><i>This is the wrapper for native function 0x5BFF36D6ED83E0AE.</i>
        /// </summary>
        /// <returns>If the pause menu is open, it will return a Vector3, Z is always 0. If the pause menu is closed, it will return Vector3.Zero</returns>
        public static Vector3 GetPauseMenuCursorPosition()
        {
            return Function.Call<Vector3>((Hash)0x5BFF36D6ED83E0AE);
        }
    }
}
