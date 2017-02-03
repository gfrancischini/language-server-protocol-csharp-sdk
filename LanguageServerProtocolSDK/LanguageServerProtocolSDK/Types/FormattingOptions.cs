using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{



    /**
 * Value-object describing what options formatting should use.
 */
    public class FormattingOptions
    {
        /**
         * Size of a tab in spaces.
         */
        [JsonProperty(PropertyName = "tabSize")]
        int TabSize
        {
            get;
            set;
        }

        /**
         * Prefer spaces over tabs.
         */
        [JsonProperty(PropertyName = "insertSpaces")]
        bool InsertSpaces
        {
            get;
            set;
        }

        /**
         * Signature for further properties.
         */
        //[key: string]: boolean | number | string;
    }
}
