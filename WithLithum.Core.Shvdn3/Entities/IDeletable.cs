using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithLithum.Core.Entities
{
    /// <summary>
    /// Represents an object that can be deleted.
    /// </summary>
    public interface IDeletable
    {
        /// <summary>
        /// Deletes this instance from the game world immediately, and sets the handle of this instance to
        /// <c>0</c>.
        /// </summary>
        /// <remarks>
        /// <note type="warning">
        /// Calls to an instance that has been deleted are invalid and will result in an exception.
        /// </note>
        /// <para>
        /// Note that you must remove this instance from a collection first if the collection uses <see cref="object.Equals(object)"/>
        /// for equality comparison, before deleting this instance.
        /// </para>
        /// </remarks>
        void Delete();
    }
}
