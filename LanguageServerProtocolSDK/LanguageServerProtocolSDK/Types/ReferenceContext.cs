using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Value-object that contains additional information when
     * requesting references.
     */
    class ReferenceContext
    {
        /**
         * Include the declaration of the current symbol.
         */
        [JsonProperty(PropertyName = "includeDeclaration")]
        bool IncludeDeclaration
        {
            get;
            set;
        }
    }
}
