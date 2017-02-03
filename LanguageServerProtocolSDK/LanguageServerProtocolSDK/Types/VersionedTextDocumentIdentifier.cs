using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * An identifier to denote a specific version of a text document.
     */
    public class VersionedTextDocumentIdentifier : TextDocumentIdentifier
    {
        /**
         * The version number of this document.
         */
        [JsonProperty(PropertyName = "version")]
        int Version
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new VersionedTextDocumentIdentifier literal.
        /// </summary>
        /// <param name="uri">The document's uri</param>
        /// <param name="version">The document's text</param>
        public VersionedTextDocumentIdentifier(string uri, int version)
            : base(uri)
        {
            this.Version = version;
        }

        public VersionedTextDocumentIdentifier()
            : base()
        {

        }
    }
}
