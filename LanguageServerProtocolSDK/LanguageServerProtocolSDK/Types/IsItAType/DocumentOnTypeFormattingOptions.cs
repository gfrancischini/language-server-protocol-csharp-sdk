using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    /**
     * Format document on type options
     */
    /// <summary>
    /// 
    /// </summary>
    public class DocumentOnTypeFormattingOptions
    {
        /// <summary>
        /// A character on which formatting should be triggered, like `}`.
        /// </summary>
        [JsonProperty(PropertyName = "firstTriggerCharacter")]
        public string FirstTriggerCharacter
        {
            get;
            set;
        }

        /// <summary>
        /// More trigger characters.
        /// </summary>
        [JsonProperty(PropertyName = "moreTriggerCharacter")]
        public List<string> MoreTriggerCharacter
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentOnTypeFormattingOptions()
        {
            MoreTriggerCharacter = new List<string>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="moreTriggerCharacter"></param>
        public DocumentOnTypeFormattingOptions(List<string> moreTriggerCharacter)
        {
            MoreTriggerCharacter = moreTriggerCharacter;
        }
    }
}
