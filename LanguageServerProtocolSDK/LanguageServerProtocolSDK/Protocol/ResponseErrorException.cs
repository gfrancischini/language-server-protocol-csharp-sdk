using LanguageServerProtocolSDK.JsonRpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    public class ResponseErrorException : Exception
    {
        public JsonRpcError<Object> Error { get; set; }

        public ResponseErrorException(JsonRpcError<Object> error)
            : base()
        {
            this.Error = error;
        }

        public ResponseErrorException(string message, JsonRpcError<Object> error)
            : base(message)
        {
            this.Error = error;
        }

        public ResponseErrorException(string message, Exception innerException, JsonRpcError<Object> error)
            : base(message, innerException)
        {
            this.Error = error;
        }
    }
}
