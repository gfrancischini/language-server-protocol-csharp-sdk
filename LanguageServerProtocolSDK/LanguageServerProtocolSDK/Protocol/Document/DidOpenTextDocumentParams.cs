using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.Document
{
    public class DidOpenTextDocumentParams
    {
        /**
         * The document that was opened.
         */
        [JsonProperty(PropertyName = "textDocument")]
        public TextDocumentItem TextDocument
        {
            get;
            set;
        }
    }
}
