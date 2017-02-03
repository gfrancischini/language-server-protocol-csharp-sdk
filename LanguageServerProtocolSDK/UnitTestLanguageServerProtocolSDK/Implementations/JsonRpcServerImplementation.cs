using LanguageServerProtocolSDK.JsonRpc;
using LanguageServerProtocolSDK.Protocol;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLanguageServerProtocolSDK.Implementations
{
    class JsonRpcServerImplementation : JsonRpcServer
    {
        public JsonRpcRequest ExposeDeserializeJsonRpcRequest(string message)
        {
            return base.DeserializeJsonRpcRequest(message);
        }


        protected override JsonRpcResponse ProcessRequest(JsonRpcRequest request)
        {
            throw new NotImplementedException();
        }

        public JsonRpcServerImplementation(Stream inputStream, Stream outputStream)
            : base(inputStream, outputStream)
        {
        }
    }
}
