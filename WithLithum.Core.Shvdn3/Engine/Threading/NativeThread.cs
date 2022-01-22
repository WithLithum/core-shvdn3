namespace WithLithum.Core.Engine.Threading;

using JetBrains.Annotations;
using Util.Native;

/// <summary>
/// Represents a native thread.
/// </summary>
[PublicAPI]
public class NativeThread
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NativeThread"/> class.
    /// </summary>
    /// <param name="id">The identifier of this instance.</param>
    public NativeThread(int id)
    {
        Id = id;
    }

    /// <summary>
    /// Gets the ID of this instance.
    /// </summary>
    public int Id { get; }

    /// <summary>
    /// Gets the name of this instance.
    /// </summary>
    public string Name => Api.GetNameOfThread(Id);

    /// <summary>
    /// Gets a value indicating whether this instance is active.
    /// </summary>
    public bool IsActive => Api.IsThreadActive(Id);

    /// <summary>
    /// Gets the current thread.
    /// </summary>
    public NativeThread Current => new(Api.GetIdOfThisThread());

    /// <summary>
    /// Terminates this instance.
    /// </summary>
    public void Terminate()
    {
        Api.TerminateThread(Id);
    }
}