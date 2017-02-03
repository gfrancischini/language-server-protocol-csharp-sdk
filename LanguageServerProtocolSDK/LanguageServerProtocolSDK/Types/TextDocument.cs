using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * A simple text document. Not to be implemenented.
     */
    public abstract class TextDocument
    {

        /**
         * The associated URI for this document. Most documents have the __file__-scheme, indicating that they
         * represent files on disk. However, some documents may have other schemes indicating that they are not
         * available on disk.
         *
         * @readonly
         */
        [JsonProperty(PropertyName = "range")]
        readonly string uri;

        /**
         * The identifier of the language associated with this document.
         *
         * @readonly
         */
        [JsonProperty(PropertyName = "range")]
        readonly string languageId;

        /**
         * The version number of this document (it will strictly increase after each
         * change, including undo/redo).
         *
         * @readonly
         */
        [JsonProperty(PropertyName = "diagnostics")]
        readonly int version;

        /**
         * Get the text of this document.
         *
         * @return The text of this document.
         */
        protected abstract string getText();

        /**
         * Converts a zero-based offset to a position.
         *
         * @param offset A zero-based offset.
         * @return A valid [position](#Position).
         */
        protected abstract Position positionAt(int offset);

        /**
         * Converts the position to a zero-based offset.
         *
         * The position will be [adjusted](#TextDocument.validatePosition).
         *
         * @param position A position.
         * @return A valid zero-based offset.
         */
        protected abstract int offsetAt(Position position);

        /**
         * The number of lines in this document.
         *
         * @readonly
         */
        readonly int lineCount;
    }
}
