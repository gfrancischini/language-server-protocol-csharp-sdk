using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    /**
     * The parameters of a notification message.
     */
    public class ShowMessageParams
    {
        /**
         * The message type. See {@link MessageType}
         */
        [JsonProperty(PropertyName = "type")]
        MessageType Type
        {
            get;
            set;
        }

        /**
         * The actual message
         */
        [JsonProperty(PropertyName = "message")]
        string Message
        {
            get;
            set;
        }
    }
}
