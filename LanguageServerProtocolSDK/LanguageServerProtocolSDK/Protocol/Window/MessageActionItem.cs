using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    class MessageActionItem
    {
        /// <summary>
        /// A short title like 'Retry', 'Open Log' etc.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        string Title
        {
            get;
            set;
        }
    }
}
