using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// 
    /// </summary>
    class TextDocumentSyncOptions
    {
        /// <summary>
        /// Open and close notifications are sent to the server.
        /// </summary>
        [JsonProperty(PropertyName = "openClose")]
        public bool OpenClose
        {
            get;
            set;
        }

        /// <summary>
        /// Change notificatins are sent to the server. See TextDocumentSyncKind.None, TextDocumentSyncKind.Full and TextDocumentSyncKindIncremental.
        /// </summary>
        [JsonProperty(PropertyName = "change")]
        public TextDocumentSyncKind Change
        {
            get;
            set;
        }

        /// <summary>
        /// Will save notifications are sent to the server.
        /// </summary>
        [JsonProperty(PropertyName = "willSave")]
        public bool WillSave
        {
            get;
            set;
        }

        /// <summary>
        /// Will save wait until requests are sent to the server.
        /// </summary>
        [JsonProperty(PropertyName = "willSaveWaitUntil")]
        public bool WillSaveWaitUntil
        {
            get;
            set;
        }

        /// <summary>
        /// Save notifications are sent to the server.
        /// </summary>
        [JsonProperty(PropertyName = "save")]
        public SaveOptions Save
        {
            get;
            set;
        }
    }

}
