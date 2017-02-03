using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    class ShowMessageRequestParams
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

        /**
         * The message action items to present.
         */
        [JsonProperty(PropertyName = "actions")]
        List<MessageActionItem> Actions
        {
            get;
            set;
        }

        public ShowMessageRequestParams()
        {
            this.Actions = new List<MessageActionItem>();
        }

        public ShowMessageRequestParams(List<MessageActionItem> actions)
        {
            this.Actions = actions;
        }
    }
}
