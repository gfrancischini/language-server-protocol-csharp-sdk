using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.JsonRpc
{
    /// <summary>
    /// 
    /// </summary>
    public enum JsonRpcErrorCode
    {
        ParseError = -32700,
        InvalidRequest = -32600,
        MethodNotFound = -32601,
        InvalidParams = -32602,
        InternalError = -32603,
        serverErrorStart = -32099,
        serverErrorEnd = -32000,
        ServerNotInitialized = -32002,
        UnknownErrorCode = -32001
    }
}
