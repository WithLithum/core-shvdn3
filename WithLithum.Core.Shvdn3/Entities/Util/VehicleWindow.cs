namespace WithLithum.Core.Entities.Util;

using GTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
