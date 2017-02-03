using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace LanguageServerProtocolSDK.Protocol
{
    /// <summary>
    /// Class with all available command types
    /// </summary>
    public class CommandType
    {
        #region General
        public const string Initialize = "initialize";
        public const string Initialized = "initialized";
        public const string Shutdown = "shutdown";
        public const string Exit = "exit";
        public const string CancelRequest = "$/cancelRequest";
        #endregion

        #region Window
        public const string WindowShowMessage = "window/showMessage";
        public const string WindowShowMessageRequest = "window/showMessageRequest";
        public const string WindowLogMessage = "window/logMessage";
        public const string TelemetryEvent = "telemetry/event";
        public const string ClientRegisterCapability = "client/registerCapability";
        public const string ClientUnregisterCapability = "client/unregisterCapability";
        #endregion

        #region Workspace
        public const string WorkspaceDidChangeConfiguration = "workspace/didChangeConfiguration";
        public const string WorkspaceDidChangeWatchedFiles = "workspace/didChangeWatchedFiles";
        public const string WorkspaceSymbol = "workspace/symbol";
        public const string WorkspaceExecuteCommand = "workspace/executeCommand";
        public const string WorkspaceApplyEdit = "workspace/applyEdit";
        #endregion

        #region Document
        public const string TextDocumentPublishDiagnostics = "textDocument/publishDiagnostics";
        public const string TextDocumentDidOpen = "textDocument/didOpen";
        public const string TextDocumentDidChange = "textDocument/didChange";
        public const string TextDocumentWillSave = "textDocument/willSave";
        public const string TextDocumentWillSaveWaitUntil = "textDocument/willSaveWaitUntil";
        public const string TextDocumentDidSave = "textDocument/didSave";
        public const string TextDocumentDidClose = "textDocument/didClose";
        public const string TextDocumentCompletion = "textDocument/completion";
        public const string CompletionItemResolve = "completionItem/resolve";
        public const string TextDocumentHover = "textDocument/hover";
        public const string TextDocumentSignatureHelp = "textDocument/signatureHelp";
        public const string TextDocumentReferences = "textDocument/references";
        public const string TextDocumentDocumentHighlight = "textDocument/documentHighlight";
        public const string TextDocumentDocumentSymbol = "textDocument/documentSymbol";
        public const string TextDocumentFormatting = "textDocument/formatting";
        public const string TextDocumentRangeFormatting = "textDocument/rangeFormatting";
        public const string TextDocumentOnTypeFormatting = "textDocument/onTypeFormatting";
        public const string TextDocumentDefinition = "textDocument/definition";
        public const string TextDocumentCodeAction = "textDocument/codeAction";
        public const string TextDocumentCodeLens = "textDocument/codeLens";
        public const string CodeLensResolve = "codeLens/resolve";
        public const string TextDocumentDocumentLink = "textDocument/documentLink";
        public const string DocumentLinkResolve = "documentLink/resolve";
        public const string TextDocumentRename = "textDocument/rename";
        #endregion
    }
}
