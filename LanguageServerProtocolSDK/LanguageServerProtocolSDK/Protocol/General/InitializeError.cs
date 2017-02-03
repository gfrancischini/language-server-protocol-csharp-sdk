using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.General
{
    /// <summary>
    /// 
    /// </summary>
    class InitializeError
    {
        /// <summary>
        /// Indicates whether the client should retry to send the
        /// initialize request after showing the message provided
        /// in the {@link ResponseError}
        /// </summary>
        [JsonProperty(PropertyName = "retry")]
        bool Retry
        {
            get;
            set;
        }
    }
}
