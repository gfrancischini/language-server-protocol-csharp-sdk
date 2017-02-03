using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.General
{
    public class CancelParams
    {
        [JsonProperty(PropertyName = "id")]
        int Id
        {
            get;
            set;
        }
    }
}
