using GTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Exceptions;
using static WithLithum.Core.Util.NativeFunctions;

namespace WithLithum.Core.Entities.Extensions
{
    /// <summary>
    /// Provides extension methods for the <see cref="Entity"/> class.
    /// </summary>
    public static class EntityExtensions
    {
        /// <summary>
        /// Sets a value indicating whether the light of this entity is on.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="on">On or off.</param>
        public static void SetLightsOn(this Entity entity, bool on)
        {
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            if (!entity.Exists()) throw new InvalidPoolObjectException(entity);

            SetEntityLights(entity.Handle, !on);
        }
    }
}
