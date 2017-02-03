using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// Completion options.
    /// </summary>
    public class CompletionOptions
    {
        /// <summary>
        /// The server provides support to resolve additional information for a completion item.
        /// </summary>
        [JsonProperty(PropertyName = "resolveProvider")]
        public Boolean ResolveProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The characters that trigger completion automatically.
        /// </summary>
        [JsonProperty(PropertyName = "triggerCharacters")]
        public List<string> TriggerCharacters
        {
            get;
            set;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CompletionOptions()
        {
            TriggerCharacters = new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="triggerCharacters"></param>
        public CompletionOptions(List<string> triggerCharacters)
        {
            TriggerCharacters = triggerCharacters;
        }

    }
}
