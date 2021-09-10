using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;
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
        /// Gets an instance of <see cref="HeadBlend"/> which can be used to manipulate head blend data of this instance.
        /// </summary>
        /// <value>
        /// An instance of <see cref="HeadBlend"/> which can be used to manipulate head blend data of this instance.
        /// </value>
        public HeadBlend Blend { get; set; }

        /// <summary>
        /// Gets an instance of <see cref="FaceFeature"/> based on the specified <see cref="FaceFeatureType"/>.
        /// </summary>
        /// <param name="type">The type of the face feature.</param>
        /// <returns>An instance of <see cref="FaceFeature"/> which can be used to change the value of a specified face feature.</returns>
        public FaceFeature this[FaceFeatureType type] => new FaceFeature(this, type);

        internal void SetHeadBlendInternal(int shapeFirstID, int shapeSecondID, int shapeThirdID, int skinFirstID, int skinSecondID, int skinThirdID, float shapeMix, float skinMix, float thirdMix, bool isParent)
        {
            Function.Call(Hash.SET_PED_HEAD_BLEND_DATA, BasePed, shapeFirstID, shapeSecondID, shapeThirdID, skinFirstID, skinSecondID, skinThirdID, shapeMix, skinMix, thirdMix, isParent);
        }
    }
}
