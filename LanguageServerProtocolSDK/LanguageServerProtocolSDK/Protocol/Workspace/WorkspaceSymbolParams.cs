using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * The parameters of a [WorkspaceSymbolRequest](#WorkspaceSymbolRequest).
     */
    class WorkspaceSymbolParams
    {
        /**
         * A non-empty query string
         */
        [JsonProperty(PropertyName = "query")]
        string Query
        {
            get;
            set;
        }
    }

}
