using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WithLithum.Core.Util.Native;

namespace WithLithum.Core.UI.Hud
{
    /// <summary>
    /// Provides methods and properties to manipulate Pause Menu.
    /// </summary>
    public static class PauseMenu
    {
        /// <summary>
        /// Gets or sets a value indicating whether the pause menu is open.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if the pause menu is open; otherwise, <see langword="false"/>.
        /// </value>
        public static bool IsOpen
        {
            get => Api.IsPauseMenuActive();
            set => Api.SetPauseMenuActive(value);
        }

        /// <summary>
        /// Gets the position of the cursor on the pause menu screen.
        /// </summary>
        /// <value>
        /// If the pause menu is open, an instance of <see cref="PointF"/> representing
        /// the cursor position; otherwise, returns 0.
        /// </value>
        public static PointF CursorPosition
        {
            get
            {
                var v3 = Api.GetPauseMenuCursorPosition();
                return new PointF(v3.X, v3.Y);
            }
        }
    }
}
