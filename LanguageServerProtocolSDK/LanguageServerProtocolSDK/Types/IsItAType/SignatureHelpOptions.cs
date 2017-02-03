using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Signature help options.
     */
    public class SignatureHelpOptions
    {
        /**
         * The characters that trigger signature help
         * automatically.
         */
        [JsonProperty(PropertyName = "triggerCharacters")]
        public List<string> TriggerCharacters
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public SignatureHelpOptions()
        {
            TriggerCharacters = new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="triggerCharacters"></param>
        public SignatureHelpOptions(List<string> triggerCharacters)
        {
            TriggerCharacters = triggerCharacters;
        }
    }
}
