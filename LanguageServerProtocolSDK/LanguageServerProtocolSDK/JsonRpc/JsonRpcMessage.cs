using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.JsonRpc
{
    /// <summary>
    /// A general message as defined by JSON-RPC. The language server protocol always uses "2.0" as the jsonrpc version.
    /// </summary>
    public class JsonRpcMessage
    {
        [JsonProperty(PropertyName = "jsonrpc")]
        public String JsonRPC { get { return "2.0"; } set { } }
    }
}
