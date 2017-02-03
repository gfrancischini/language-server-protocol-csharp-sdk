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
    /**
     * Params for the CodeActionRequest
     */
    public class CodeActionParams : BaseParams
    {
        /**
         * The document in which the command was invoked.
         */
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /**
         * The range for which the command was invoked.
         */
        [JsonProperty(PropertyName = "range")]
        Range Range
        {
            get;
            set;
        }

        /**
         * Context carrying additional information.
         */
        [JsonProperty(PropertyName = "context")]
        CodeActionContext Context
        {
            get;
            set;
        }
    }
}
