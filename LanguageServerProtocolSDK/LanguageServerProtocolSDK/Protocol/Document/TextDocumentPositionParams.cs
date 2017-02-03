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
    /// A parameter literal used in requests to pass a text document and a position inside that document.
    /// </summary>
    public class TextDocumentPositionParams
    {
        /// <summary>
        /// The text document.
        /// </summary>
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /// <summary>
        /// The position inside the text document.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        Position Position
        {
            get;
            set;
        }
    }
}
