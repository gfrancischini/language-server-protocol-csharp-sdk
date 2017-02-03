using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    public class RegistrationParams
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "registrations")]
        List<Registration> Registrations
        {
            get;
            set;
        }

        public RegistrationParams()
        {
            this.Registrations = new List<Registration>();
        }

        public RegistrationParams(List<Registration> registrations)
        {
            this.Registrations = registrations;
        }
    }
}
