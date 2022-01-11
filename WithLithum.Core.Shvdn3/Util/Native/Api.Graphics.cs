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
#pragma warning disable S107 // Methods should not have too many parameters
        public static int CreateCheckpoint(int type, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float diameter, int red, int green, int blue, int alpha, int reserved)
#pragma warning restore S107 // Methods should not have too many parameters
            => Function.Call<int>(Hash.CREATE_CHECKPOINT, type, posX1, posY1, posZ1, posX2, posY2, posZ2, diameter, red, green, blue, alpha, reserved);

        public static void DeleteCheckpoint(int checkpoint)
            => Function.Call(Hash.DELETE_CHECKPOINT, checkpoint);
    }
}
