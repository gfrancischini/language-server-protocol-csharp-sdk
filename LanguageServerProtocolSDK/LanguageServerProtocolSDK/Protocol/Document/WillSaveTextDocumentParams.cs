using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    /**
     * The parameters send in a will save text document notification.
     */
    public class WillSaveTextDocumentParams
    {
        /**
         * The document that will be saved.
         */
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /**
         * The 'TextDocumentSaveReason'.
         */
        [JsonProperty(PropertyName = "reason")]
        TextDocumentSaveReason Reason
        {
            get;
            set;
        }
    }
}
