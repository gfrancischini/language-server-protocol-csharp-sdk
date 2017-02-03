using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * The result of a hover request.
     */
    class Hover
    {
        /**
         * The hover's content
         */
        [JsonProperty(PropertyName = "contents")]
        List<MarkedString> Contents
        {
            get;
            set;
        }

        /**
         * An optional range
         */
        [JsonProperty(PropertyName = "range")]
        Range Range
        {
            get;
            set;
        }
    }
}
