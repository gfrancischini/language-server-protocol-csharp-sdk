using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Document link options
     */
    public class DocumentLinkOptions
    {
        /**
         * Document links have a resolve provider as well.
         */
        [JsonProperty(PropertyName = "resolveProvider")]
        bool ResolveProvider
        {
            get;
            set;
        }
    }
}
