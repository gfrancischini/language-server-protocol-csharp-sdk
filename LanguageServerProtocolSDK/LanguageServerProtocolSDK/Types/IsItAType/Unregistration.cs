using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * General parameters to unregister a request or notification.
     */
    public class Unregistration
    {
        /**
         * The id used to unregister the request or notification. Usually an id
         * provided during the register request.
         */
        [JsonProperty(PropertyName = "id")]
        string Id
        {
            get;
            set;
        }

        /**
         * The method to unregister for.
         */
        [JsonProperty(PropertyName = "method")]
        string Method
        {
            get;
            set;
        }
    }
}
