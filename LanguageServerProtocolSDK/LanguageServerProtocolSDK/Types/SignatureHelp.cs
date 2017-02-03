using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Signature help represents the signature of something
     * callable. There can be multiple signature but only one
     * active and only one active parameter.
     */
    class SignatureHelp
    {
        /**
         * One or more signatures.
         */
        [JsonProperty(PropertyName = "signatures")]
        SignatureInformation[] Signatures
        {
            get;
            set;
        }

        /**
         * The active signature.
         */
        [JsonProperty(PropertyName = "activeSignature")]
        int ActiveSignature
        {
            get;
            set;
        }

        /**
         * The active parameter of the active signature.
         */
        [JsonProperty(PropertyName = "activeParameter")]
        int ActiveParameter
        {
            get;
            set;
        }
    }

}
