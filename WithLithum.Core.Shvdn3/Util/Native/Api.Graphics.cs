// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Util.Native;

using GTA.Native;

public static partial class Api
{
#pragma warning disable S107 // Methods should not have too many parameters

    public static int CreateCheckpoint(int type, float posX1, float posY1, float posZ1, float posX2, float posY2, float posZ2, float diameter, int red, int green, int blue, int alpha, int reserved)
#pragma warning restore S107 // Methods should not have too many parameters
            => Function.Call<int>(Hash.CREATE_CHECKPOINT, type, posX1, posY1, posZ1, posX2, posY2, posZ2, diameter, red, green, blue, alpha, reserved);

    public static void DeleteCheckpoint(int checkpoint)
        => Function.Call(Hash.DELETE_CHECKPOINT, checkpoint);
}