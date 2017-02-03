using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// General text document registration options.
    /// </summary>
    public class TextDocumentRegistrationOptions
    {
        /// <summary>
        /// A document selector to identify the scope of the registration. If set to null
        /// the document selector provided on the client side will be used.
        /// </summary>
        [JsonProperty(PropertyName = "documentSelector")]
        List<DocumentFilter> documentSelector
        {
            get;
            set;
        }
    }

}
