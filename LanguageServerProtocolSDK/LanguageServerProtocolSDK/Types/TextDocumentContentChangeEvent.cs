using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{


    /**
 * An event describing a change to a text document. If range and rangeLength are omitted
 * the new text is considered to be the full content of the document.
 */
    public class TextDocumentContentChangeEvent
    {
        /**
         * The range of the document that changed.
         */
        [JsonProperty(PropertyName = "range")]
        Range Range
        {
            get;
            set;
        }

        /**
         * The length of the range that got replaced.
         */
        [JsonProperty(PropertyName = "rangeLength")]
        int RangeLength
        {
            get;
            set;
        }

        /**
         * The new text of the document.
         */
        [JsonProperty(PropertyName = "text")]
        public string Text
        {
            get;
            set;
        }
    }
}
