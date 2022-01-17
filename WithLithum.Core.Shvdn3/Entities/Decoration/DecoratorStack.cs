using System;
using WithLithum.Core.Util.Native;

namespace WithLithum.Core.Entities.Decoration;

/// <summary>
/// Provides utilities to manipulate decorators.
/// </summary>
public class DecoratorStack
{
    private WEntity _owner;
    private static bool _finalized;
    
    /// <summary>
    /// Initializes a new instance of the <see cref="DecoratorStack"/> class.
    /// </summary>
    /// <param name="owner">The owner.</param>
    public DecoratorStack(WEntity owner)
    {
        _owner = owner;
    }

    /// <summary>
    /// Determines whether the specified decorator exists in this instance.
    /// </summary>
    /// <param name="name">The name to check.</param>
    /// <returns><see langword="true"/> if the specified decorator exists; otherwise, <see langword="false"/>.</returns>
    public bool Contains(string name)
    {
        return Api.DecorExistOn(_owner.Handle, name);
    }
    
    #region Static (Global) Methods
    /// <summary>
    /// Represents a decorator to the game engine.
    /// </summary>
    /// <param name="name">The name of the decorator.</param>
    /// <param name="type">The type of the decorator.</param>
    /// <exception cref="InvalidOperationException">Decorator registration has been finalized.</exception>
    public static void RegisterDecorator(string name, DecoratorType type)
    {
        if (_finalized)
        {
            throw new InvalidOperationException("Decorator registration has been finalized.");
        }
        
        Api.DecorRegister(name, (int)type);
    }

    /// <summary>
    /// Finalizes the registration process of decorators.
    /// Further decorator registration is invalid and will result in an exception.
    /// </summary>
    public static void FinalizeDecoratorRegistration()
    {
        _finalized = true;
        Api.DecorRegisterLock();
    }
    #endregion
}