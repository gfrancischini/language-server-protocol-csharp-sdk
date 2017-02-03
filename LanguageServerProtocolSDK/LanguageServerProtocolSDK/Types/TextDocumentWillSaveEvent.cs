using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    class TextDocumentWillSaveEvent
    {
        /**
         * The document that will be saved
         */
        [JsonProperty(PropertyName = "document")]
        TextDocument Document
        {
            get;
            set;
        }

        /**
         * The reason why save was triggered.
         */
        [JsonProperty(PropertyName = "reason")]
        TextDocumentSaveReason Reason
        {
            get;
            set;
        }
    }
}
