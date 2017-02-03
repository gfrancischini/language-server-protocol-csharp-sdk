using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    public class LogMessageParams
    {
        /// <summary>
        /// The message type. See {@link MessageType}
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        MessageType Type
        {
            get;
            set;
        }

        //The actual message
        [JsonProperty(PropertyName = "message")]
        string Message
        {
            get;
            set;
        }
    }
}
