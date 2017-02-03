using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Describes textual changes on a text document.
     */
    class TextDocumentEdit
    {
        /**
         * The text document to change.
         */
        [JsonProperty(PropertyName = "textDocument")]
        VersionedTextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /**
         * The edits to be applied.
         */
        [JsonProperty(PropertyName = "edits")]
        List<TextEdit> Edits
        {
            get;
            set;
        }

        public TextDocumentEdit()
        {
            this.Edits = new List<TextEdit>();
        }

        public TextDocumentEdit(List<TextEdit> edits)
        {
            this.Edits = edits;
        }
    }
}
