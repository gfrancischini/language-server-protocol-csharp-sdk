using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.JsonRpc
{
    /// <summary>
    /// Response Message sent as a result of a request.
    /// </summary>
    public class JsonRpcResponse : JsonRpcMessage
    {
        /// <summary>
        /// The request id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// The result of a request. This can be omitted in the case of an error.
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public JObject Result { get; set; }

        /// <summary>
        /// The error object in case a request fails.
        /// </summary>
        [JsonProperty(PropertyName = "error", NullValueHandling = NullValueHandling.Ignore)]
        public JsonRpcError<Object> Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="result"></param>
        public JsonRpcResponse(Int32 id)
        {
            Id = id;
        }
    }

}
