using LanguageServerProtocolSDK.Protocol;
using LanguageServerProtocolSDK.Protocol.General;
using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDKConsole
{
    /// <summary>
    /// A samples language server reference class
    /// </summary>
    class SampleLanguageServer : LanguageServerProtocol
    {
        public SampleLanguageServer(Stream inputStream, Stream outputStream)
            : base(inputStream, outputStream)
        {
        }


        public override InitializeResult Initialize(InitializeParams param)
        {
            ServerCapabilities capabilities = new ServerCapabilities()
            {
                CodeActionProvider = true,
                CodeLensProvider = new CodeLensOptions()
                {
                    ResolveProvider = true
                },
                CompletionProvider = new CompletionOptions()
                {
                    ResolveProvider = true
                },
                DefinitionProvider = true,
                DocumentFormattingProvider = true,
                DocumentHighlightProvider = true,
                DocumentOnTypeFormattingProvider = new DocumentOnTypeFormattingOptions()
                {
                    FirstTriggerCharacter = "A"
                },
                DocumentRangeFormattingProvider = true,
                DocumentSymbolProvider = true,
                HoverProvider = true,
                ReferencesProvider = true,
                RenameProvider = true,
                SignatureHelpProvider = new SignatureHelpOptions(),
                TextDocumentSync = TextDocumentSyncKind.Full,
                WorkspaceSymbolProvider = true
            };

            InitializeResult initializeResult = new InitializeResult(capabilities);

            return initializeResult;
        }




        public override LanguageServerProtocolSDK.Protocol.Document.TextDocumentDefinitionResult TextDocumentDefinition(LanguageServerProtocolSDK.Protocol.Document.TextDocumentPositionParams param)
        {
            throw new NotImplementedException();
        }

        public override LanguageServerProtocolSDK.Protocol.Document.TextDocumentFormattingResult TextDocumentFormatting(LanguageServerProtocolSDK.Protocol.Document.DocumentFormattingParams param)
        {
            throw new NotImplementedException();
        }

        public override LanguageServerProtocolSDK.Protocol.Document.TextDocumentCompletionResult TextDocumentCompletion(LanguageServerProtocolSDK.Protocol.Document.TextDocumentPositionParams param)
        {
            throw new NotImplementedException();
        }

        public override LanguageServerProtocolSDK.Protocol.Document.CompletionItemResult CompletionItemResolve(CompletionItem param)
        {
            throw new NotImplementedException();
        }

        public override LanguageServerProtocolSDK.Protocol.Document.TextDocumentHoverResult TextDocumentHover(LanguageServerProtocolSDK.Protocol.Document.TextDocumentPositionParams param)
        {
            throw new NotImplementedException();
        }

        public override void TextDocumentDidChange(LanguageServerProtocolSDK.Protocol.Document.DidChangeTextDocumentParams param)
        {
            throw new NotImplementedException();
        }

        public override void TextDocumentDidSave(LanguageServerProtocolSDK.Protocol.Document.DidSaveTextDocumentParams param)
        {
            throw new NotImplementedException();
        }

        public override void TextDocumentDidOpen(LanguageServerProtocolSDK.Protocol.Document.DidOpenTextDocumentParams param)
        {
            throw new NotImplementedException();
        }

        public override void Initialized()
        {
            throw new NotImplementedException();
        }

        public override void Shutdown()
        {
            throw new NotImplementedException();
        }

        public override void Exit()
        {
            throw new NotImplementedException();
        }

        public override void WorkspaceDidChangeConfiguration(DidChangeConfigurationParams param)
        {
            throw new NotImplementedException();
        }

        public override void WorkspaceDidChangeWatchedFiles(DidChangeWatchedFilesParams param)
        {
            throw new NotImplementedException();
        }

        public override void TextDocumentWillSave(WillSaveTextDocumentParams param)
        {
            throw new NotImplementedException();
        }

        public override void TextDocumentDidClose(LanguageServerProtocolSDK.Protocol.Document.DidCloseTextDocumentParams param)
        {
            throw new NotImplementedException();
        }
    }
}
