// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Entities.Util;

public class VehicleWindow
{
    private readonly WVehicle _owner;

    internal VehicleWindow(WVehicle vehicle, VehicleWindowIndex index)
    {
        _owner = vehicle;
        Index = index;
    }

    public VehicleWindowIndex Index { get; }
}