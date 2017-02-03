using LanguageServerProtocolSDK.JsonRpc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    public class NotificationMessage : JsonRpcMessage
    {
        /**
         * The method to be invoked.
         */
        [JsonProperty(PropertyName = "method")]
        public string Method
        {
            get;
            set;
        }

        /**
         * The notification's params.
         */
        [JsonProperty(PropertyName = "params")]
        public dynamic Args
        {
            get;
            set;
        }
    }
}
