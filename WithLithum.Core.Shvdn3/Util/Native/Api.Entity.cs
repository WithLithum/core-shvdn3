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

        /// <summary>
        /// this enables or disables lights on things such as objects.<br />
        /// <i>This is the wrapper for native function 0x7CFBA6A80BDF3874.</i>
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="toggle">when toggle is set to true it turns off the lights, when false it turns them on.</param>
        public static void SetEntityLights(int entity, bool toggle) => Function.Call(Hash.SET_ENTITY_LIGHTS, entity, toggle);
    }
}
