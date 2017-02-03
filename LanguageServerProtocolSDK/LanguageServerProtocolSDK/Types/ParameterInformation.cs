using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Represents a parameter of a callable-signature. A parameter can
     * have a label and a doc-comment.
     */
    class ParameterInformation
    {
        /**
         * The label of this signature. Will be shown in
         * the UI.
         */
        [JsonProperty(PropertyName = "label")]
        string Label
        {
            get;
            set;
        }

        /**
         * The human-readable doc-comment of this signature. Will be shown
         * in the UI but can be omitted.
         */
        [JsonProperty(PropertyName = "documentation")]
        string Documentation
        {
            get;
            set;
        }
    }
}
