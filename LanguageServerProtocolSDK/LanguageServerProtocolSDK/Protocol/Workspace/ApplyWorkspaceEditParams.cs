using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    /**
     * The parameters passed via a apply workspace edit request.
     */
    public class ApplyWorkspaceEditParams
    {
        /**
         * The edits to apply.
         */
        [JsonProperty(PropertyName = "edit")]
        WorkspaceEdit Edit
        {
            get;
            set;
        }
    }
}
