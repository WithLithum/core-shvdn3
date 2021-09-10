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
    public class HeadBlendCustomizator
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HeadBlendCustomizator"/> class.
        /// </summary>
        /// <param name="ped">The ped to customize.</param>
        public HeadBlendCustomizator(Ped ped)
        {
            if (ped == null) throw new ArgumentNullException(nameof(ped));
            if (!ped.Exists()) throw new InvalidPoolObjectException(ped);

            BasePed = ped;
        }

        /// <summary>
        /// Gets the ped of this instance.
        /// </summary>
        public Ped BasePed { get; }
    }
}
