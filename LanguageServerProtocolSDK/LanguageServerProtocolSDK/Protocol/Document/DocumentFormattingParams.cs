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
    public class DocumentFormattingParams
    {
        /// <summary>
        /// The document to format.
        /// </summary>
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /// <summary>
        /// The format options
        /// </summary>
        [JsonProperty(PropertyName = "options")]
        FormattingOptions Options
        {
            get;
            set;
        }
    }
}
