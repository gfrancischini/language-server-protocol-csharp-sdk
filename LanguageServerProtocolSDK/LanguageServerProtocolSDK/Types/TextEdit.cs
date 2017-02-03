using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{


    /// <summary>
    /// A text edit applicable to a text document.
    /// </summary>
    public class TextEdit
    {
        /**
         * The range of the text document to be manipulated. To insert
         * text into a document create a range where start === end.
         */
        [JsonProperty(PropertyName = "range")]
        public Range Range
        {
            get;
            set;
        }

        /**
         * The string to be inserted. For delete operations use an
         * empty string.
         */
        [JsonProperty(PropertyName = "newText")]
        public string NewText
        {
            get;
            set;
        }
    }




}
