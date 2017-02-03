using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// Descibe options to be used when registered for text document change events.
    /// </summary>
    public class TextDocumentChangeRegistrationOptions : TextDocumentRegistrationOptions
    {
        /// <summary>
        /// How documents are synced to the server.
        /// </summary>
        [JsonProperty(PropertyName = "syncKind")]
        TextDocumentSyncKind SyncKind
        {
            get;
            set;
        }
    }
}
