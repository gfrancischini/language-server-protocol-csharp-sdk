using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Event to signal changes to a simple text document.
     */
    class TextDocumentChangeEvent
    {
        /**
         * The document that has changed.
         */
        [JsonProperty(PropertyName = "document")]
        TextDocument Document
        {
            get;
            set;
        }
    }
}
