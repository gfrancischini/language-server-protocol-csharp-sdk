using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    public class TextDocumentPosition
    {
        /**
     * The text document.
     */
        [JsonProperty(PropertyName = "textDocument")]
        public TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /**
         * The position inside the text document.
         */
        [JsonProperty(PropertyName = "position")]
        public Position Position
        {
            get;
            set;
        }
    }
}
