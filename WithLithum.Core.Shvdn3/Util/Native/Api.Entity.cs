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
        public static void SetEntityLights(uint entity, bool toggle) => Function.Call(Hash.SET_ENTITY_LIGHTS, entity, toggle);

        /// <summary>
        /// <i>No description provided.</i>
        /// </summary>
        /// <param name="entity"><i>No description provided.</i></param>
        /// <returns><i>No description provided.</i></returns>
        public static bool IsEntityVisible(uint /* Entity */ entity) => Function.Call<bool>(Hash.IS_ENTITY_VISIBLE, entity);

        /// <summary>
        /// Toggle the visibility of a given entity.
        /// </summary>
        /// <param name="entity">The entity to change the visibility of</param>
        /// <param name="toggle">Whether or not the entity will be visible</param>
        /// <param name="unk">Always 0 in scripts</param>
        public static void SetEntityVisible(uint /* Entity */ entity, bool toggle, bool unk = false) => Function.Call(Hash.SET_ENTITY_VISIBLE, entity, toggle, unk);

        /// <summary>
        /// Set the heading of an entity in degrees also known as "Yaw".
        /// </summary>
        /// <param name="entity">The entity to set the heading for.</param>
        /// <param name="heading">The heading in degrees.</param>
        public static void SetEntityHeading(uint /* Entity */ entity, float heading) => Function.Call(Hash.SET_ENTITY_HEADING, entity, heading);

        /// <summary>
        /// Gets the heading of the specified entity.
        /// </summary>
        /// <param name="entity">The entity to get the heading from.</param>
        /// <returns>The current entity heading.</returns>
        public static float GetEntityHeading(uint entity) => Function.Call<float>(Hash.GET_ENTITY_HEADING, entity, 0, 0, 0);

        /// <summary>
        /// <i>No description provided.</i>
        /// </summary>
        /// <param name="vehicle"><i>No description provided.</i></param>
        /// <returns><i>No description provided.</i></returns>
        public static bool IsPlaybackGoingOnForVehicle(uint /* Vehicle */ vehicle) => Function.Call<bool>(Hash.IS_PLAYBACK_GOING_ON_FOR_VEHICLE, vehicle);

        /// <summary>
        /// Deletes the specified entity, then sets the handle pointed to by the pointer to NULL.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        public static void DeleteEntity(ref uint entity)
        {
            var cf = entity;
            unsafe
            {
                Function.Call(Hash.DELETE_ENTITY, &cf);
            }
            entity = cf;
        }

        /// <summary>
        /// Returns the handle of the interior that the entity is in. Returns 0 if outside. 
        /// </summary>
        /// <param name="entity">The entity to check.</param>
        /// <returns>If inside an interior, the ID of the interior; otherwise, <c>0</c>.</returns>
        public static int GetInteriorFromEntity(uint /* Entity */ entity) => Function.Call<int>(Hash.GET_INTERIOR_FROM_ENTITY, entity);
    }
}
