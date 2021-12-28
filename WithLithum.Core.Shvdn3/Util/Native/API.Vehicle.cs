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
        /// <summary>
        /// <i>No description provided.</i>
        /// </summary>
        /// <param name="vehicle"><i>No description provided.</i></param>
        /// <returns>Returns 1000.0 if the function is unable to get the address of the specified vehicle or if it's not a vehicle. </returns>
        public static float GetVehicleEngineHealth(int vehicle) => Function.Call<float>(Hash.GET_VEHICLE_ENGINE_HEALTH, vehicle);

        /// <summary>
        /// <i>No description provided.</i>
        /// </summary>
        /// <param name="vehicle"><i>No description provided.</i></param>
        /// <param name="value"><i>No description provided.</i></param>
        public static void SetVehicleEngineHealth(int vehicle, float value) => Function.Call(Hash.SET_VEHICLE_ENGINE_HEALTH, vehicle, value);

        /// <summary>
        /// Only ever used once in decompiled scripts: am_pi_menu: Returns true if the engine is on fire, or if the vehicle engine health is lesser than 0 and it has been on fire.
        /// </summary>
        /// <param name="vehicle">The vehicle to check.</param>
        /// <returns>Returns true when the engine of your vehicle is on fire. Returns false if it's not on fire.</returns>
        public static bool IsVehicleEngineOnFire(int vehicle) => Function.Call<bool>(Hash._IS_VEHICLE_ENGINE_ON_FIRE, vehicle);
    }
}
