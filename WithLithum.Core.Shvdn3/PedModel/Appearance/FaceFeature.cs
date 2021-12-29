﻿using GTA;
using GTA.Native;

namespace WithLithum.Core.PedModel.Appearance
{
    /// <summary>
    /// Provides utilties to manipulate a specific face feature of freemode model head blends.
    /// </summary>
    public class FaceFeature
    {
        private readonly HeadBlendCustomizer _customizer;

        internal FaceFeature(HeadBlendCustomizer customizer, FaceFeatureType type)
        {
            Type = type;
            _customizer = customizer;
        }

        /// <summary>
        /// Gets the type of the feature that is manipulate by this instance.
        /// </summary>
        /// <value>
        /// The type of this instance.
        /// </value>
        public FaceFeatureType Type { get; }

        private Ped Ped => _customizer.BasePed;

        /// <summary>
        /// Sets the value of this instance.
        /// </summary>
        /// <param name="value">The value.</param>
        public void SetValue(float value)
        {
            Function.Call(Hash._SET_PED_FACE_FEATURE, Ped, (int)Type, value);
        }
    }
}
