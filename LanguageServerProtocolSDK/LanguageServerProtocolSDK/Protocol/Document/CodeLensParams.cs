using LanguageServerProtocolSDK.Protocol.Base;
using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.Document
{
    /// <summary>
    /// Params for the Code Lens request.
    /// </summary>
    public class CodeLensParams : BaseParams
    {
        /// <summary>
        /// The document to request code lens for.
        /// </summary>
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }
    }
}
