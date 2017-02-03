using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    public class UnregistrationParams
    {
        [JsonProperty(PropertyName = "unregisterations")]
        List<Unregistration> Unregisterations
        {
            get;
            set;
        }

        public UnregistrationParams()
        {
            this.Unregisterations = new List<Unregistration>();
        }

        public UnregistrationParams(List<Unregistration> unregisterations)
        {
            this.Unregisterations = unregisterations;
        }
    }
}
