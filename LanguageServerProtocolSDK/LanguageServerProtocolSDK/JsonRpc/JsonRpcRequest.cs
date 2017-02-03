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
    /// 
    /// </summary>
    public class JsonRpcRequest : JsonRpcMessage
    {


        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="method"></param>
        /// <param name="parameters"></param>
        public JsonRpcRequest(Int32 id, String method, dynamic parameters)
        {
            Id = id;
            Method = method;
            Parameters = parameters;
        }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public String Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "params")]
        public JObject Parameters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public Int32 Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>The serealized bytes</returns>
        public Byte[] GetBytes()
        {
            String json = JsonConvert.SerializeObject(this);
            return Encoding.UTF8.GetBytes(json);
        }
    }
}
