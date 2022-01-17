using GTA.Native;

namespace WithLithum.Core.Util.Native;

public static partial class Api
{
    /// <summary>
    /// Registers a decorator.
    /// </summary>
    /// <param name="propertyName">The name.</param>
    /// <param name="type">The type.</param>
    public static void DecorRegister(string propertyName, int type)
        => Function.Call(Hash.DECOR_REGISTER, propertyName, type);

    /// <summary>
    /// Called after all decorator type initializations.
    /// </summary>
    public static void DecorRegisterLock()
        => Function.Call(Hash.DECOR_REGISTER_LOCK);

    /// <summary>
    /// Returns whether or not the specified property is set for the entity. 
    /// </summary>
    /// <param name="entity"><i>No description provided.</i></param>
    /// <param name="propertyName"><i>No description provided.</i></param>
    /// <returns><i>No description provided.</i></returns>
    public static bool DecorExistOn(uint /* Entity */ entity, string propertyName)
        => Function.Call<bool>(Hash.DECOR_EXIST_ON, entity, propertyName);
}