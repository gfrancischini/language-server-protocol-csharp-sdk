using LanguageServerProtocolSDK.Protocol.Base;
using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.General
{
    /**
     * The result returned from an initilize request.
     */
    public class InitializeResult : BaseResult
    {
        /// <summary>
        /// The capabilities the language server provides.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public ServerCapabilities Capabilities { get; set; }

        /// <summary>
        /// Create a new InitializeResult
        /// </summary>
        public InitializeResult()
        {
            this.Capabilities = new ServerCapabilities();
        }

        /// <summary>
        /// Create a new InitializeResult
        /// </summary>
        /// <param name="capabilities">The capabilities the language server provides.</param>
        public InitializeResult(ServerCapabilities capabilities)
        {
            this.Capabilities = capabilities;
        }
    }

}
