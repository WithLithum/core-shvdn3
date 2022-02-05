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
        /// <param name="ringtoneName"><i>No description provided.</i></param>
        /// <param name="ped"><i>No description provided.</i></param>
        /// <param name="p2"><i>No description provided.</i></param>
        public static void PlayPedRingtone(string ringtoneName, int /* Ped */ ped, bool p2)
            => Function.Call(Hash.PLAY_PED_RINGTONE, ringtoneName, ped, p2);

        /// <summary>
        /// <i>No description provided.</i>
        /// </summary>
        /// <param name="ped"><i>No description provided.</i></param>
        /// <returns><i>No description provided.</i></returns>
        public static bool IsPedRingtonePlaying(int /* Ped */ ped)
            => Function.Call<bool>(Hash.IS_PED_RINGTONE_PLAYING, ped);

        /// <summary>
        /// <i>No description provided.</i>
        /// </summary>
        /// <param name="ped"><i>No description provided.</i></param>
        public static void StopPedRingtone(int /* Ped */ ped)
            => Function.Call(Hash.STOP_PED_RINGTONE, ped);
    }
}
