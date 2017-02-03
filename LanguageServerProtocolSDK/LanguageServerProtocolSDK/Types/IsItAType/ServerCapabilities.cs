using LanguageServerProtocolSDK.Protocol.Types;
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
    public class ServerCapabilities
    {

        /// <summary>
        /// Defines how text documents are synced.
        /// </summary>
        [JsonProperty(PropertyName = "textDocumentSync")]
        public TextDocumentSyncKind TextDocumentSync
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides hover support.
        /// </summary>
        [JsonProperty(PropertyName = "hoverProvider")]
        public bool HoverProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides completion support.
        /// </summary>
        [JsonProperty(PropertyName = "completionProvider")]
        public CompletionOptions CompletionProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides signature help support.
        /// </summary>
        [JsonProperty(PropertyName = "signatureHelpProvider")]
        public SignatureHelpOptions SignatureHelpProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides goto definition support.
        /// </summary>
        [JsonProperty(PropertyName = "definitionProvider")]
        public Boolean DefinitionProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides find references support.
        /// </summary>
        [JsonProperty(PropertyName = "referencesProvider")]
        public Boolean ReferencesProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides document highlight support.
        /// </summary>
        [JsonProperty(PropertyName = "documentHighlightProvider")]
        public Boolean DocumentHighlightProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides document symbol support.
        /// </summary>
        [JsonProperty(PropertyName = "documentSymbolProvider")]
        public Boolean DocumentSymbolProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides workspace symbol support.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceSymbolProvider")]
        public Boolean WorkspaceSymbolProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides code actions.
        /// </summary>
        [JsonProperty(PropertyName = "codeActionProvider")]
        public Boolean CodeActionProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides code lens.
        /// </summary>
        [JsonProperty(PropertyName = "codeLensProvider")]
        public CodeLensOptions CodeLensProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides document formatting.
        /// </summary>
        [JsonProperty(PropertyName = "documentFormattingProvider")]
        public Boolean DocumentFormattingProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides document range formatting.
        /// </summary>
        [JsonProperty(PropertyName = "documentRangeFormattingProvider")]
        public Boolean DocumentRangeFormattingProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides document formatting on typing.
        /// </summary>
        [JsonProperty(PropertyName = "documentOnTypeFormattingProvider")]
        public DocumentOnTypeFormattingOptions DocumentOnTypeFormattingProvider
        {
            get;
            set;
        }

        /// <summary>
        /// The server provides rename support.
        /// </summary>
        [JsonProperty(PropertyName = "renameProvider")]
        public Boolean RenameProvider
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public ServerCapabilities()
        {
            this.CompletionProvider = new CompletionOptions();
        }
    }

}
