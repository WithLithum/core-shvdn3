using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.Util.Native
{
    public static partial class API
    {
        public static void PlayPedRingtone(string ringtoneName, int /* Ped */ ped, bool p2)
            => Function.Call(Hash.PLAY_PED_RINGTONE, ped, p2);

        public static bool IsPedRingtonePlaying(int /* Ped */ ped)
            => Function.Call<bool>(Hash.IS_PED_RINGTONE_PLAYING, ped);

        public static void StopPedRingtone(int /* Ped */ ped)
            => Function.Call(Hash.STOP_PED_RINGTONE, ped);
    }
}
