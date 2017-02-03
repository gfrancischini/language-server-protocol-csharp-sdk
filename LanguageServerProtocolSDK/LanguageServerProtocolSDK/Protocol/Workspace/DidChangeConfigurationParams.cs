using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    /// <summary>
    /// The parameters of a change configuration notification.
    /// </summary>
    public class DidChangeConfigurationParams
    {
        /// <summary>
        /// The actual changed settings
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public Object Settings
        {
            get;
            set;
        }
    }

}
