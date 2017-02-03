using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.Document
{
    /**
     * The publish diagnostic notification's parameters.
     */
    public class PublishDiagnosticsParams
    {
        /**
          * The URI for which diagnostic information is reported.
          */
        [JsonProperty(PropertyName = "uri")]
        public string Uri
        {
            get;
            set;
        }

        /**
         * An array of diagnostic information items.
         */
        [JsonProperty(PropertyName = "diagnostics")]
        public List<Diagnostic> Diagnostics
        {
            get;
            set;
        }

        PublishDiagnosticsParams()
        {
            this.Diagnostics = new List<Diagnostic>();
        }

        PublishDiagnosticsParams(List<Diagnostic> diagnostics)
        {
            this.Diagnostics = diagnostics;
        }
    }
}
