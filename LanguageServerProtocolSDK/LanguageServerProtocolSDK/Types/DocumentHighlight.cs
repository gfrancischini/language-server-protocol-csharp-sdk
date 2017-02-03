using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * A document highlight is a range inside a text document which deserves
     * special attention. Usually a document highlight is visualized by changing
     * the background color of its range.
     */
    class DocumentHighlight
    {
        /**
         * The range this highlight applies to.
         */
        [JsonProperty(PropertyName = "range")]
        Range Range
        {
            get;
            set;
        }

        /**
         * The highlight kind, default is [text](#DocumentHighlightKind.Text).
         */
        [JsonProperty(PropertyName = "kind")]
        DocumentHighlightKind Kind
        {
            get;
            set;
        }
    }
}
