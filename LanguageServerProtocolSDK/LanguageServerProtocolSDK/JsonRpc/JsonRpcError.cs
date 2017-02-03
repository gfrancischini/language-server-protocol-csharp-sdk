using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.JsonRpc
{
    public class JsonRpcError<ErrorData>
    {
        /// <summary>
        /// A number indicating the error type that occurred.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public JsonRpcErrorCode Code { get; set; }

        /// <summary>
        /// A string providing a short description of the error.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// A Primitive or Structured value that contains additional
        /// information about the error. Can be omitted.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public ErrorData Data { get; set; }
    }
}
