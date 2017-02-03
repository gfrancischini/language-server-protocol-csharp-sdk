using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Save options.
     */
    public class SaveOptions
    {
        /**
         * The client is supposed to include the content on save.
         */
        [JsonProperty(PropertyName = "includeText")]
        bool IncludeText
        {
            get;
            set;
        }
    }
}
