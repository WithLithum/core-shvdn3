namespace WithLithum.Core.Util.Native;

using GTA.Native;

public static partial class Api
{
    /// <summary>
    /// Gets the ID of this thread.
    /// </summary>
    /// <returns>The ID of this thread.</returns>
    public static int GetIdOfThisThread()
        => Function.Call<int>(Hash.GET_ID_OF_THIS_THREAD);

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="threadId"><i>No description provided.</i></param>
    /// <returns><i>No description provided.</i></returns>
    public static string GetNameOfThread(int threadId)
        => Function.Call<string>(Hash._GET_NAME_OF_THREAD, threadId);

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="threadId"><i>No description provided.</i></param>
    /// <returns><i>No description provided.</i></returns>
    public static bool IsThreadActive(int threadId)
        => Function.Call<bool>(Hash.IS_THREAD_ACTIVE, threadId);

    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="threadId"><i>No description provided.</i></param>
    public static void TerminateThread(int threadId)
        => Function.Call(Hash.TERMINATE_THREAD, threadId);
}
