using System;
using GTA;
using WithLithum.Core.PedModel.Appearance;

namespace WithLithum.Core.PedModel
{
    /// <summary>
    /// Provide extension methods to <see cref="Ped"/> class.
    /// </summary>
    public static class PedExtensions
    {
        /// <summary>
        /// Receives an instance of <see cref="HeadBlendCustomizer"/> which can be used to edit the face features,
        /// head blend datas, etc. of this instance.
        /// </summary>
        /// <param name="ped">The ped.</param>
        /// <returns>An instance of <see cref="HeadBlendCustomizer"/>. Multiple calls with the same ped are not guaranteed to return the same instance.</returns>
        public static HeadBlendCustomizer HeadBlend(this Ped ped)
        {
            return new HeadBlendCustomizer(ped);
        }
    }
}
