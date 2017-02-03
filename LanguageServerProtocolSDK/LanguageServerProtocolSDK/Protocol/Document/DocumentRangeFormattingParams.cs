using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.Document
{
    public class DocumentRangeFormattingParams
    {
        /**
         * The document to format.
         */
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /**
         * The range to format
         */
        [JsonProperty(PropertyName = "range")]
        Range Range
        {
            get;
            set;
        }

        /**
         * The format options
         */
        [JsonProperty(PropertyName = "options")]
        FormattingOptions Options
        {
            get;
            set;
        }
    }
}
