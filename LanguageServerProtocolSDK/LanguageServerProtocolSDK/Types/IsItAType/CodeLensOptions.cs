using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// Code Lens options.
    /// </summary>
    public class CodeLensOptions
    {
        /// <summary>
        /// Code lens has a resolve provider as well.
        /// </summary>
        [JsonProperty(PropertyName = "resolveProvider")]
        public bool ResolveProvider
        {
            get;
            set;
        }
    }
}
