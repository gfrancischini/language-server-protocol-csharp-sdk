using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Represents the signature of something callable. A signature
     * can have a label, like a function-name, a doc-comment, and
     * a set of parameters.
     */
    class SignatureInformation
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

        /**
         * The parameters of this signature.
         */
        [JsonProperty(PropertyName = "parameters")]
        List<ParameterInformation> Parameters
        {
            get;
            set;
        }

        public SignatureInformation()
        {
            this.Parameters = new List<ParameterInformation>();
        }

        public SignatureInformation(List<ParameterInformation> parameters)
        {
            this.Parameters = parameters;
        }
    }
}
