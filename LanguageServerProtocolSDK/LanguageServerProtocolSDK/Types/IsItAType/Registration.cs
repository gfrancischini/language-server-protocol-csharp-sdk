using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * General paramters to to regsiter for an notification or to register a provider.
     */
    public class Registration
    {
        /**
         * The id used to register the request. The id can be used to deregister
         * the request again.
         */
        [JsonProperty(PropertyName = "id")]
        string Id
        {
            get;
            set;
        }

        /**
         * The method to register for.
         */
        [JsonProperty(PropertyName = "method")]
        string Method
        {
            get;
            set;
        }

        /**
         * Options necessary for the registration.
         */
        //registerOptions?: any;
    }
}
