using LanguageServerProtocolSDK.JsonRpc;
using LanguageServerProtocolSDK.Protocol.Base;
using LanguageServerProtocolSDK.Protocol.Document;
using LanguageServerProtocolSDK.Protocol.General;
using LanguageServerProtocolSDK.Protocol.Types;
using LanguageServerProtocolSDK.Types;
using LanguageServerProtocolSDK.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    /// <summary>
    /// The ProtocolServer can be used to implement a server that uses the VSCode Language Server Protocol.
    /// </summary>
    public abstract class LanguageServerProtocol : JsonRpcServer
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputStream"></param>
        /// <param name="outputStream"></param>
        public LanguageServerProtocol(Stream inputStream, Stream outputStream)
            : base(inputStream, outputStream)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <param name="id"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        protected JObject ProcessMethod(string method, int id, JObject args)
        {
            BaseResult result = null;
            switch (method)
            {
                #region General
                case CommandType.Initialize:
                    result = this.Initialize(args.ToObject<InitializeParams>());
                    break;
                case CommandType.Initialized:
                    this.Initialized();
                    break;
                case CommandType.Shutdown:
                    this.Shutdown();
                    break;
                case CommandType.Exit:
                    this.Exit();
                    break;
                case CommandType.CancelRequest:
                    break;
                #endregion

                #region Window
                //case CommandType.WindowShowMessage:
                //    break;
                //case CommandType.WindowShowMessageRequest:
                //    break;
                //case CommandType.WindowLogMessage:
                //    break;
                //case CommandType.TelemetryEvent:
                //    break;
                //case CommandType.ClientRegisterCapability:
                //    break;
                //case CommandType.ClientUnregisterCapability:
                //    break;
                #endregion

                #region Workspace
                case CommandType.WorkspaceDidChangeConfiguration:
                    this.WorkspaceDidChangeConfiguration(args.ToObject<DidChangeConfigurationParams>());
                    break;
                case CommandType.WorkspaceDidChangeWatchedFiles:
                    this.WorkspaceDidChangeWatchedFiles(args.ToObject<DidChangeWatchedFilesParams>());
                    break;
                #endregion

                #region Document
                //case CommandType.TextDocumentPublishDiagnostics:
                //    break;
                case CommandType.TextDocumentDidOpen:
                    this.TextDocumentDidOpen(args.ToObject<DidOpenTextDocumentParams>());
                    break;
                case CommandType.TextDocumentDidChange:
                    this.TextDocumentDidChange(args.ToObject<DidChangeTextDocumentParams>());
                    break;
                case CommandType.TextDocumentWillSave:
                    this.TextDocumentWillSave(args.ToObject<WillSaveTextDocumentParams>());
                    break;
                //case CommandType.TextDocumentWillSaveWaitUntil:
                //    break;
                case CommandType.TextDocumentDidSave:
                    this.TextDocumentDidSave(args.ToObject<DidSaveTextDocumentParams>());
                    break;
                case CommandType.TextDocumentDidClose:
                    this.TextDocumentDidClose(args.ToObject<DidCloseTextDocumentParams>());
                    break;
                case CommandType.TextDocumentCompletion:
                    result = this.TextDocumentCompletion(args.ToObject<TextDocumentPositionParams>());
                    break;
                case CommandType.CompletionItemResolve:
                    result = this.CompletionItemResolve(args.ToObject<CompletionItem>());
                    break;
                case CommandType.TextDocumentHover:
                    result = this.TextDocumentHover(args.ToObject<TextDocumentPositionParams>());
                    break;
                //case CommandType.TextDocumentSignatureHelp:
                //    break;
                //case CommandType.TextDocumentReferences:
                //    break;
                //case CommandType.TextDocumentDocumentHighlight:
                //    break;
                //case CommandType.TextDocumentDocumentSymbol:
                //    break;
                case CommandType.TextDocumentFormatting:
                    result = this.TextDocumentFormatting(args.ToObject<DocumentFormattingParams>());
                    break;
                //case CommandType.TextDocumentRangeFormatting:
                //    break;
                //case CommandType.TextDocumentOnTypeFormatting:
                //    break;
                case CommandType.TextDocumentDefinition:
                    result = this.TextDocumentDefinition(args.ToObject<TextDocumentPositionParams>());
                    break;
                //case CommandType.TextDocumentCodeAction:
                //    break;
                //case CommandType.TextDocumentCodeLens:
                //    break;
                //case CommandType.CodeLensResolve:
                //    break;
                //case CommandType.TextDocumentDocumentLink:
                //    break;
                //case CommandType.DocumentLinkResolve:
                //    break;
                //case CommandType.TextDocumentRename:
                //    break;
                #endregion

                default:
                    JsonRpcError<Object> error = new JsonRpcError<object>
                    {
                        Code = JsonRpcErrorCode.MethodNotFound,
                        Data = ErrorsMessage.GetUnrecognizedRequest(method, id)
                    };
                    throw new ResponseErrorException(error);
            }
            if (result != null)
            {
                return result.ToJObject();
            }
            return null;
        }

        /// <summary>
        /// Check whether the method needs to respond.
        /// </summary>
        /// <param name="method">The Method name</param>
        /// <returns>True when the method needs to respond</returns>
        protected Boolean IsMethodResponseRequired(string method)
        {
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected override JsonRpcResponse ProcessRequest(JsonRpcRequest request)
        {
            JsonRpcResponse response = new JsonRpcResponse(request.Id);
            try
            {
                JObject result = this.ProcessMethod(request.Method, request.Id, request.Parameters);

                //if there is no response but a response is required we should throw an error
                if (result == null && IsMethodResponseRequired(request.Method) == true)
                {
                    response.Error = new JsonRpcError<object>()
                    {
                        Code = JsonRpcErrorCode.InternalError,
                        Message = ErrorsMessage.GetRequiredMethodResponse(request.Method, request.Id)
                    };
                }
                response.Result = result;

            }
            catch (ResponseErrorException e)
            {
                response.Error = e.Error;
            }
            catch (Exception e)
            {
                response.Error = new JsonRpcError<object>()
                {
                    Code = JsonRpcErrorCode.UnknownErrorCode,
                    Message = ErrorsMessage.GetErrorProcessingRequest(request.Method, request.Id, e.StackTrace.ToString())
                };
            }


            return response;
        }

        #region Requests

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public abstract InitializeResult Initialize(InitializeParams param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public abstract TextDocumentDefinitionResult TextDocumentDefinition(TextDocumentPositionParams param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public abstract TextDocumentFormattingResult TextDocumentFormatting(DocumentFormattingParams param);

        /// <summary>
        /// The Completion request is sent from the client to the server to compute completion items at a given cursor position. Completion items are presented in the IntelliSense user interface. If computing full completion items is expensive, servers can additionally provide a handler for the completion item resolve request ('completionItem/resolve'). This request is sent when a completion item is selected in the user interface. A typically use case is for example: the 'textDocument/completion' request doesn't fill in the documentation property for returned completion items since it is expensive to compute. When the item is selected in the user interface then a 'completionItem/resolve' request is sent with the selected completion item as a param. The returned completion item should have the documentation property filled in.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public abstract TextDocumentCompletionResult TextDocumentCompletion(TextDocumentPositionParams param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public abstract CompletionItemResult CompletionItemResolve(CompletionItem param);

        /// <summary>
        /// The hover request is sent from the client to the server to request hover information at a given text document position.
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public abstract TextDocumentHoverResult TextDocumentHover(TextDocumentPositionParams param);
        #endregion

        #region Notifications

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        public abstract void TextDocumentDidChange(DidChangeTextDocumentParams param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        public abstract void TextDocumentDidSave(DidSaveTextDocumentParams param);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        public abstract void TextDocumentDidOpen(DidOpenTextDocumentParams param);

        /// <summary>
        /// 
        /// </summary>
        public abstract void Initialized();

        /// <summary>
        /// 
        /// </summary>
        public abstract void Shutdown();

        /// <summary>
        /// 
        /// </summary>
        public abstract void Exit();

        /// <summary>
        /// A notification sent from the client to the server to signal the change of configuration settings.
        /// </summary>
        /// <param name="param"></param>
        public abstract void WorkspaceDidChangeConfiguration(DidChangeConfigurationParams param);

        /// <summary>
        /// The watched files notification is sent from the client to the server when the client detects changes to files watched by the language client.
        /// </summary>
        /// <param name="param"></param>
        public abstract void WorkspaceDidChangeWatchedFiles(DidChangeWatchedFilesParams param);

        /// <summary>
        /// The document will save notification is sent from the client to the server before the document is actually saved.
        /// </summary>
        /// <param name="param"></param>
        public abstract void TextDocumentWillSave(WillSaveTextDocumentParams param);

        /// <summary>
        /// The document close notification is sent from the client to the server when the document got closed in the client. The document's truth now exists where the document's uri points to (e.g. if the document's uri is a file uri the truth now exists on disk).
        /// </summary>
        /// <param name="param"></param>
        public abstract void TextDocumentDidClose(DidCloseTextDocumentParams param);
        #endregion


    }
}
