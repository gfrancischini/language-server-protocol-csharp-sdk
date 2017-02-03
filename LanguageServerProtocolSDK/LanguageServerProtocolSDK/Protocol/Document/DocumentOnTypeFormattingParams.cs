using LanguageServerProtocolSDK.Protocol.Base;
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
    public class DocumentOnTypeFormattingParams : BaseParams
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
         * The position at which this request was send.
         */
        [JsonProperty(PropertyName = "position")]
        Position Position
        {
            get;
            set;
        }

        /**
         * The character that has been typed.
         */
        [JsonProperty(PropertyName = "ch")]
        string Character
        {
            get;
            set;
        }

        /**
         * The format options.
         */
        [JsonProperty(PropertyName = "options")]
        FormattingOptions Options
        {
            get;
            set;
        }
    }
}
