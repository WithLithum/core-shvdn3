using GTA.Native;

namespace WithLithum.Core.Util.Native
{
    public static partial class Api
    {
        /// <summary>
        /// <i>No description provided.</i>
        /// </summary>
        /// <param name="entity"><i>No description provided.</i></param>
        /// <returns><i>No description provided.</i></returns>
        public static bool IsEntityOnFire(uint /* Entity */ entity) => Function.Call<bool>(Hash.IS_ENTITY_ON_FIRE, entity);
    }
}
