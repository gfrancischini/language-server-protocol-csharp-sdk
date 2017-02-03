using LanguageServerProtocolSDK.Protocol.Base;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.General
{
    /// <summary>
    /// The initialize parameters
    /// </summary>
    public class InitializeParams : BaseParams
    {
        /// <summary>
        /// The process Id of the parent process that started the server.
        /// </summary>
        [JsonProperty(PropertyName = "processId")]
        public int ProcessId
        {
            get;
            protected set;
        }

        /// <summary>
        /// The rootPath of the workspace. Is null if no folder is open.
        /// @deprecated in favour of rootUri.
        /// </summary>
        [JsonProperty(PropertyName = "rootPath")]
        public string RootPath
        {
            get;
            protected set;
        }

        /// <summary>
        /// The rootUri of the workspace. Is null if no folder is open.
        /// </summary>
        [JsonProperty(PropertyName = "rootUri")]
        public string RootUri
        {
            get;
            protected set;
        }

        /// <summary>
        /// The capabilities provided by the client (editor or tool)
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public ClientCapabilities Capabilities
        {
            get;
            protected set;
        }

        /**
         * User provided initialization options.
         */
        //initializationOptions?: any;

        /**
         * The initial trace setting. If omitted trace is disabled ('off').
         */
        //trace?: 'off' | 'messages' | 'verbose';
    }
}
