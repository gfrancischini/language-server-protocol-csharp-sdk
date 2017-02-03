using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Parameters for a [DocumentSymbolRequest](#DocumentSymbolRequest).
     */
    class DocumentSymbolParams
    {
        /**
         * The text document.
         */
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }
    }
}
