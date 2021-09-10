using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using WithLithum.Core.Shvdn3.Exceptions;

namespace WithLithum.Core.Shvdn3.PedModel.Appearance
{
    /// <summary>
    /// Provides head blend customization to model <see cref="PedHash.FreemodeMale01"/> and <see cref="PedHash.FreemodeFemale01"/>.
    /// </summary>
    public class HeadBlendCustomizer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeadBlendCustomizer"/> class.
        /// </summary>
        /// <param name="ped">The ped to customize.</param>
        public HeadBlendCustomizer(Ped ped)
        {
            if (ped == null) throw new ArgumentNullException(nameof(ped));
            if (!ped.Exists()) throw new InvalidPoolObjectException(ped);

            BasePed = ped;
        }

        /// <summary>
        /// Gets the ped of this instance.
        /// </summary>
        public Ped BasePed { get; }

        /// <summary>
        /// Gets an instance of <see cref="FaceFeature"/> based on the specified <see cref="FaceFeatureType"/>.
        /// </summary>
        /// <param name="type">The type of the face feature.</param>
        /// <returns>An instance of <see cref="FaceFeature"/> which can be used to change the value of a specified face feature.</returns>
        public FaceFeature this[FaceFeatureType type]
        {
            get => new FaceFeature(this, type);
        }
    }
}
