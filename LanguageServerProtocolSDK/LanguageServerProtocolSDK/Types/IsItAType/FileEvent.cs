using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * An event describing a file change.
     */
    public class FileEvent
    {
        /**
         * The file's uri.
         */
        [JsonProperty(PropertyName = "uri")]
        string Uri
        {
            get;
            set;
        }

        /**
         * The change type.
         */
        [JsonProperty(PropertyName = "type")]
        FileChangeType Type
        {
            get;
            set;
        }
    }
}
