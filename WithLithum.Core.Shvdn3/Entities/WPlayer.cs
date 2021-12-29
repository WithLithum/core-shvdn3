using GTA;
using GTA.Native;

namespace WithLithum.Core.Entities
{
    /// <summary>
    /// Represents a player. This class is a wrapper for <see cref="Player"/> with extended features.
    /// </summary>
    public class WPlayer : INativeValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WPlayer"/> class.
        /// </summary>
        /// <param name="basePlayer">The base player.</param>
        public WPlayer(Player basePlayer)
        {
            GtaPlayer = basePlayer;
        }

        /// <summary>
        /// Gets the original SHVDN player class.
        /// </summary>
        /// <value>
        /// The player, as the original SHVDN player class.
        /// </value>
        public Player GtaPlayer { get; }

        /// <summary>
        /// Gets or sets a value indicating whether this player can control the character.
        /// </summary>
        /// <value>
        /// <see langword="true"/> if this player can control it's character; otherwise, <see langword="false"/>.
        /// </value>
        public bool CanControlCharacter
        {
            get => GtaPlayer.CanControlCharacter;
            set => GtaPlayer.CanControlCharacter = value;
        }

        /// <summary>
        /// Gets the character of this player.
        /// </summary>
        /// <value>
        /// A <see cref="Ped"/> representing the character of this player.
        /// </value>
        public Ped Character => GtaPlayer.Character;

        /// <inheritdoc cref="INativeValue.NativeValue"/>
        public ulong NativeValue { get => GtaPlayer.NativeValue; set => GtaPlayer.NativeValue = value; }
    }
}
