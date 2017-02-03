using LanguageServerProtocolSDK.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Defines the capabilities provided by the client.
     */
    public class ClientCapabilities
    {
        /**
         * Workspace specific client capabilities.
         */
        [JsonProperty(PropertyName = "workspace")]
        WorkspaceClientCapabilites Workspace
        {
            get;
            set;
        }

        /**
         * Text document specific client capabilities.
         */
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentClientCapabilities TextDocument
        {
            get;
            set;
        }

        /**
         * Experimental client capabilities.
         */
        [JsonProperty(PropertyName = "experimental")]
        Object Experimental
        {
            get;
            set;
        }
    }
}
