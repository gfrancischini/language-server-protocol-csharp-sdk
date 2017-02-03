using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{

    public class ExecuteCommandParams
    {

        /**
         * The identifier of the actual command handler.
         */
        [JsonProperty(PropertyName = "command")]
        string Command
        {
            get;
            set;
        }

        /**
         * Arguments that the command should be invoked with.
         */
        [JsonProperty(PropertyName = "arguments")]
        Object Arguments
        {
            get;
            set;
        }
    }
}
