using WithLithum.Core.Util;
using WithLithum.Core.Util.Native;

namespace WithLithum.Core.UI
{
    /// <summary>
    /// Represents a GXT text label.
    /// </summary>
    public class TranslatableText : Text
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TranslatableText"/> class.
        /// </summary>
        /// <param name="label">The label.</param>
        public TranslatableText(string label)
        {
            Label = label;
        }

        /// <summary>
        /// Gets or sets the label of this instance.
        /// </summary>
        public string Label { get; set; }

        /// <inheritdoc />
        public override void Add()
        {
            Api.AddTextComponentSubstringTextLabel(Label);
        }
    }
}
