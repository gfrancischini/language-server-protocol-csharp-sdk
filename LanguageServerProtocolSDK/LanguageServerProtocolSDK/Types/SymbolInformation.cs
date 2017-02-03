using LanguageServerProtocolSDK.Protocol.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Represents information about programming constructs like variables, classes,
     * interfaces etc.
     */
    class SymbolInformation
    {
        /**
         * The name of this symbol.
         */
        [JsonProperty(PropertyName = "name")]
        string Name
        {
            get;
            set;
        }

        /**
         * The kind of this symbol.
         */
        [JsonProperty(PropertyName = "kind")]
        SymbolKind Kind
        {
            get;
            set;
        }

        /**
         * The location of this symbol.
         */
        [JsonProperty(PropertyName = "location")]
        Location Location
        {
            get;
            set;
        }

        /**
         * The name of the symbol containing this symbol.
         */
        [JsonProperty(PropertyName = "containerName")]
        string ContainerName
        {
            get;
            set;
        }
    }
}
