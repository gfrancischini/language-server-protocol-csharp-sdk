using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.Document
{
    public class RenameParams
    {
        /**
         * The document to format.
         */
        [JsonProperty(PropertyName = "textDocument")]
        TextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /**
         * The position at which this request was send.
         */
        [JsonProperty(PropertyName = "position")]
        Position Position
        {
            get;
            set;
        }

        /**
         * The new name of the symbol. If the given name is not valid the
         * request must return a [ResponseError](#ResponseError) with an
         * appropriate message set.
         */
        [JsonProperty(PropertyName = "newName")]
        string NewName
        {
            get;
            set;
        }
    }
}
