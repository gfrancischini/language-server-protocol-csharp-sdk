using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// A literal to identify a text document in the client.
    /// </summary>
    public class TextDocumentIdentifier
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

        /// <summary>
        /// Creates a new TextDocumentIdentifier literal.
        /// </summary>
        /// <param name="URI">The document's uri</param>
        public TextDocumentIdentifier(string uri)
        {
            this.Uri = uri;
        }

        public TextDocumentIdentifier()
        {

        }
    }

}
