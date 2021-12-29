using GTA;
using System;
using WithLithum.Core.Exceptions;
using WithLithum.Core.Util.Native;

namespace WithLithum.Core.Entities
{
    /// <summary>
    /// Wrappers of <see cref="Vehicle"/> with additional utilties.
    /// </summary>
    public class WVehicle : IDeletable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WVehicle"/> class.
        /// </summary>
        /// <param name="gtaVehicle">The vehicle.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="gtaVehicle"/> was null.</exception>
        /// <exception cref="ArgumentException">Thrown when <paramref name="gtaVehicle"/> was invalid.</exception>
        public WVehicle(Vehicle gtaVehicle)
        {
            if (gtaVehicle == null)
            {
                throw new ArgumentNullException(nameof(gtaVehicle));
            }

            if (!gtaVehicle.Exists())
            {
                throw new ArgumentException("Invalid vehicle!", nameof(gtaVehicle));
            }

            this.Internal = gtaVehicle;
        }

        /// <summary>
        /// Gets the internal GTA instance of this instance.
        /// </summary>
        public Vehicle Internal { get; }

        /// <summary>
        /// Gets a value indicating whether this vehicle has it's engine on fire.
        /// </summary>
        /// <remarks>
        /// This property performs several checks based on vehicle engine health. To learn more,
        /// see the Vehicle Engine Health documentation.
        /// </remarks>
        public bool IsEngineOnFire
        {
            get
            {
                CheckValidCall();
                return Api.IsVehicleEngineOnFire(Internal.Handle);
            }
        }

        /// <summary>
        /// Gets or sets the hit points remaining for the engine of this vehicle.
        /// </summary>
        /// <remarks>
        /// The hit points of an engine is between -4000 and 1000 (inclusive).
        /// <para>
        /// When the health of the engine is at <c>1000</c>, it's in perfect condition. When it drops below
        /// <c>300</c>, it will start to smoke.
        /// </para>
        /// <para>
        /// If the hit points are below <c>0</c>, it will catch on fire (when <see cref="IsEngineOnFire"/> will return <see langword="true"/>)
        /// , and after the fire is out, the engine will be unable to start and vulnerable to damages (it will catch on fire again on
        /// some damage).
        /// </para>
        /// <para>
        /// If the vehicle is destoryed, it will return <c>-4000</c>.
        /// </para>
        /// <para>
        /// If the hit points are just at <c>0</c> the engine will go out and unable to start, but it will not catch on fire.
        /// </para>
        /// </remarks>
        public float EngineHealth
        {
            get
            {
                CheckValidCall();
                return Api.GetVehicleEngineHealth(Internal.Handle);
            }
            set
            {
                CheckValidCall();
                Api.SetVehicleEngineHealth(Internal.Handle, value);
            }
        }

        private void CheckValidCall()
        {
            if (!Internal.Exists()) throw new InvalidPoolObjectException(Internal);
        }

        /// <inheritdoc />
        public void Delete()
        {
            Internal.Delete();
        }
    }
}
