// Copyright (C) WithLithum & contributors 2021-2022.
// Licensed under LGPL-3.0-or-later license. See LICENSE for more info.

namespace WithLithum.Core.Util.Native;

using GTA.Native;

public static partial class Api
{
    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="x"><i>No description provided.</i></param>
    /// <param name="y"><i>No description provided.</i></param>
    /// <param name="z"><i>No description provided.</i></param>
    public static void LoadScene(float x, float y, float z) => Function.Call(Hash.LOAD_SCENE, x, y, z);

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="entity"><i>No description provided.</i></param>
    /// <returns><i>No description provided.</i></returns>
    public static bool IsEntityFocus(int /* Entity */ entity)
        => Function.Call<bool>(Hash.IS_ENTITY_FOCUS, entity);

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    public static void ClearFocus()
        => Function.Call(Hash.CLEAR_FOCUS);

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <returns><i>No description provided.</i></returns>
    public static int GetNumberOfEvents()
        => Function.Call<int>(Hash.GET_NUMBER_OF_EVENTS);
}