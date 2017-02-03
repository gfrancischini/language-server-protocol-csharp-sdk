using LanguageServerProtocolSDK.Protocol.Base;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.Document
{

    /// <summary>
    /// 
    /// </summary>
    public class DidChangeTextDocumentParams : BaseParams
    {
        /// <summary>
        /// The document that did change. The version number points
        /// to the version after all provided content changes have
        /// been applied.
        /// </summary>
        [JsonProperty(PropertyName = "textDocument")]
        public VersionedTextDocumentIdentifier TextDocument
        {
            get;
            set;
        }

        /// <summary>
        /// The actual content changes.
        /// </summary>
        [JsonProperty(PropertyName = "contentChanges")]
        public TextDocumentContentChangeEvent[] ContentChanges
        {
            get;
            set;
        }
    }

}
