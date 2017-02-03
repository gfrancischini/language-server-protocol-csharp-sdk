using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// Contains additional diagnostic information about the context in which
    /// [code action](#CodeActionProvider.provideCodeActions) is run.
    /// </summary>
    class CodeActionContext
    {
        /// <summary>
        /// An array of diagnostics.
        /// </summary>
        [JsonProperty(PropertyName = "diagnostics")]
        List<Diagnostic> Diagnostics
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public CodeActionContext()
        {
            this.Diagnostics = new List<Diagnostic>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="diagnostic"></param>
        public CodeActionContext(List<Diagnostic> diagnostic)
        {
            this.Diagnostics = diagnostic;
        }
    }
}
