using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    /// <summary>
    /// Represents a diagnostic, such as a compiler error or warning. 
    /// Diagnostic objects are only valid in the scope of a resource.
    /// </summary>
    public class Diagnostic
    {


        /**
         * The range at which the message applies.
         */
        [JsonProperty(PropertyName = "range")]
        public Range Range
        {
            get;
            set;
        }

        /**
         * The diagnostic's severity. Can be omitted. If omitted it is up to the
         * client to interpret diagnostics as error, warning, info or hint.
         */
        [JsonProperty(PropertyName = "severity")]
        public DiagnosticSeverity Severity
        {
            get;
            set;
        }

        /**
         * The diagnostic's code. Can be omitted.
         */
        [JsonProperty(PropertyName = "code")]
        public string Code
        {
            get;
            set;
        }

        /**
         * A human-readable string describing the source of this
         * diagnostic, e.g. 'typescript' or 'super lint'.
         */
        [JsonProperty(PropertyName = "source")]
        public string Source
        {
            get;
            set;
        }

        /**
         * The diagnostic's message.
         */
        [JsonProperty(PropertyName = "message")]
        public string Message
        {
            get;
            set;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="range"></param>
        /// <param name="severity"></param>
        /// <param name="code"></param>
        /// <param name="source"></param>
        /// <param name="message"></param>
        public Diagnostic(Range range, DiagnosticSeverity severity, string code, string source, string message)
        {
            this.Range = range;
            this.Severity = severity;
            this.Code = code;
            this.Source = source;
            this.Message = message;
        }

        public Diagnostic()
        {

        }

    }
}
