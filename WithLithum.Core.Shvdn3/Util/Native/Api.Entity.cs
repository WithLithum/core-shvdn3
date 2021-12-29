using GTA.Native;

namespace WithLithum.Core.Util.Native
{
    public static partial class Api
    {
        /// <summary>
        /// Checks whether an entity exists in the game world.
        /// </summary>
        /// <param name="entity">The entity to check if it exists.</param>
        /// <returns>Whether the entity exists or not.</returns>
        public static bool DoesEntityExist(uint /* Entity */ entity) => Function.Call<bool>(Hash.DOES_ENTITY_EXIST, entity);
    }
}
