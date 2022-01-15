// Copyright (C) WithLithum & contributors 2021.

namespace WithLithum.Core.Util.Native;

using GTA;
using GTA.Math;
using GTA.Native;
using System;

[CLSCompliant(false)]
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

#pragma warning disable S107 // Methods should not have too many parameters
    public static void ApplyForceToEntity(uint /* Entity */ entity, int forceType, float x, float y, float z, float offX, float offY, float offZ, int boneIndex, bool isDirectionRel, bool ignoreUpVec, bool isForceRel, bool p12, bool p13)
#pragma warning restore S107 // Methods should not have too many parameters
    {
        Function.Call(Hash.APPLY_FORCE_TO_ENTITY, entity, forceType, x, y, z, offX, offY, offZ, boneIndex, isDirectionRel, ignoreUpVec, isForceRel, p12, p13);
    }

    /// <summary>
    /// A static ped will not react to natives like "APPLY_FORCE_TO_ENTITY" or "SET_ENTITY_VELOCITY" and oftentimes will not react to task-natives like "AI::TASK_COMBAT_PED".
    /// The only way I know of to make one of these peds react is to ragdoll them (or sometimes to use CLEAR_PED_TASKS_IMMEDIATELY(). Static peds include almost all far-away peds,
    /// beach-combers, peds in certain scenarios, peds crossing a crosswalk, peds walking to get back into their cars, and others. If anyone knows how to make a ped non-static without
    /// ragdolling them, please edit this with the solution.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns><i>No description provided.</i></returns>
    public static bool IsEntityStatic(uint /* Entity */ entity) => Function.Call<bool>(Hash.IS_ENTITY_STATIC, entity);

    /// <summary>
    /// Gets the velocity of the specified entity.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns>An instance of <see cref="Vector3"/> representing the velocity.</returns>
    public static Vector3 GetEntityVelocity(uint /* Entity */ entity) => Function.Call<Vector3>(Hash.GET_ENTITY_VELOCITY, entity);

    /// <summary>
    /// Note that the third parameter(denoted as z) is "up and down" with positive numbers encouraging upwards movement.
    /// </summary>
    /// <param name="entity"><i>No description provided.</i></param>
    /// <param name="x"><i>No description provided.</i></param>
    /// <param name="y"><i>No description provided.</i></param>
    /// <param name="z"><i>No description provided.</i></param>
    public static void SetEntityVelocity(uint /* Entity */ entity, float x, float y, float z)
        => Function.Call(Hash.SET_ENTITY_VELOCITY, entity, x, y, z);

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="entity"><i>No description provided.</i></param>
    /// <returns><i>No description provided.</i></returns>
    public static bool IsEntityDead(uint /* Entity */ entity)
        => Function.Call<bool>(Hash.IS_ENTITY_DEAD, entity);

    /// <summary>
    /// Sets whether the entity was invincible.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="toggle">Whether invincible.</param>
    public static void SetEntityInvincible(uint /* Entity */ entity, bool toggle)
    {
        Function.Call(Hash.SET_ENTITY_INVINCIBLE, entity, toggle);
    }

    /// <summary>
    /// Gets the current coordinates (world position) for a specified entity.
    /// </summary>
    /// <param name="entity">The entity to get the coordinates from.</param>
    /// <param name="alive">Unused by the game, potentially used by debug builds of GTA in order to assert whether or not an entity was alive.</param>
    /// <returns>The current entity coordinates.</returns>
    public static Vector3 GetEntityCoords(uint entity, bool alive)
    {
        return Function.Call<Vector3>(Hash.GET_ENTITY_COORDS, entity, alive);
    }

    /// <summary>
    /// Sets the coordinates (world position) for a specified entity, offset by the radius of the entity on the Z axis.
    /// </summary>
    /// <param name="entity">The entity to change coordinates for.</param>
    /// <param name="xPos">The X coordinate.</param>
    /// <param name="yPos">The Y coordinate.</param>
    /// <param name="zPos">The Z coordinate, ground level.</param>
    /// <param name="alive">Unused by the game, potentially used by debug builds of GTA in order to assert whether or not an entity was alive.</param>
    /// <param name="deadFlag">Whether to disable physics for dead peds, too, and not just living peds.</param>
    /// <param name="ragdollFlag">A special flag used for ragdolling peds.</param>
    /// <param name="clearArea">Whether to clear any entities in the target area.</param>
#pragma warning disable S107 // Methods should not have too many parameters
    public static void SetEntityCoords(uint /* Entity */ entity, float xPos, float yPos, float zPos, bool alive, bool deadFlag, bool ragdollFlag, bool clearArea)
#pragma warning restore S107 // Methods should not have too many parameters
    {
        Function.Call(Hash.SET_ENTITY_COORDS, entity, xPos, yPos, zPos, alive, deadFlag, ragdollFlag, clearArea);
    }

    /// <summary>
    /// Gets the health of the specified instance.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns>Hit points.</returns>
    public static int GetEntityHealth(uint entity)
    {
        return Function.Call<int>(Hash.GET_ENTITY_HEALTH, entity);
    }

    /// <summary>
    /// Sets the health of this instance.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="health">The health.</param>
    public static void SetEntityHealth(uint /* Entity */ entity, int health)
    {
        Function.Call(Hash.SET_ENTITY_HEALTH, entity, health);
    }

    /// <summary>
    /// Gets the max health of the specified instance.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <returns>Hit points.</returns>
    public static int GetEntityMaxHealth(uint entity)
    {
        return Function.Call<int>(Hash.GET_ENTITY_MAX_HEALTH, entity);
    }

    /// <summary>
    /// Sets the max health of this instance.
    /// </summary>
    /// <param name="entity">The entity.</param>
    /// <param name="health">The health.</param>
    public static void SetEntityMaxHealth(uint /* Entity */ entity, int health)
    {
        Function.Call(Hash.SET_ENTITY_MAX_HEALTH, entity, health);
    }
}
