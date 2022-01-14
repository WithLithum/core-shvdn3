namespace WithLithum.Core.Util.Native;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static partial class Api
{
    /// <summary>
    /// <i>No description provided.</i>
    /// </summary>
    /// <param name="x"><i>No description provided.</i></param>
    /// <param name="y"><i>No description provided.</i></param>
    /// <param name="z"><i>No description provided.</i></param>
    public static void LoadScene(float x, float y, float z) => Function.Call(Hash.LOAD_SCENE, x, y, z);
}
