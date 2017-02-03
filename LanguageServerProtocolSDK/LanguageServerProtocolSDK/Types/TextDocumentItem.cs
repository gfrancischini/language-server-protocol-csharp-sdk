using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * An item to transfer a text document from the client to the
     * server.
     */
    public class TextDocumentItem
    {
        /**
         * The text document's URI.
         */
        [JsonProperty(PropertyName = "uri")]
        public string Uri
        {
            get;
            set;
        }

        /**
         * The text document's language identifier.
         */
        [JsonProperty(PropertyName = "languageId")]
        public string LanguageId
        {
            get;
            set;
        }

        /**
         * The version number of this document (it will strictly increase after each
         * change, including undo/redo).
         */
        [JsonProperty(PropertyName = "version")]
        public int Version
        {
            get;
            set;
        }

        /**
         * The content of the opened text document.
         */
        [JsonProperty(PropertyName = "text")]
        public string Text
        {
            get;
            set;
        }
    }
}
