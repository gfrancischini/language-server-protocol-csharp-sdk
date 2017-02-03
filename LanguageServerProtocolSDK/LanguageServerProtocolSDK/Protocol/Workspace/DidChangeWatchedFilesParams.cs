using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    /**
     * The watched files change notification's parameters.
     */
    public class DidChangeWatchedFilesParams
    {
        /**
         * The actual file events.
         */
        [JsonProperty(PropertyName = "changes")]
        FileEvent[] Changes
        {
            get;
            set;
        }
    }
}
