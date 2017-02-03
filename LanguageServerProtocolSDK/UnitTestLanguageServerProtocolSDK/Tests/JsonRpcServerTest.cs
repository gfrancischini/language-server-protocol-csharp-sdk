using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageServerProtocolSDK.Protocol;
using Newtonsoft.Json;
using LanguageServerProtocolSDK.JsonRpc;
using LanguageServerProtocolSDK.Protocol.General;
using UnitTestLanguageServerProtocolSDK.Utils;
using UnitTestLanguageServerProtocolSDK.Implementations;

namespace UnitTestLanguageServerProtocolSDK.Tests
{
    [TestClass]
    public class JsonRpcServerTest
    {
        [TestMethod]
        public void CheckRouteMethodInitialize()
        {
            string content = Utilities.LoadFile("initialize", "request", "method_initialize_1.json");

            JsonRpcServerImplementation jsonRpcServer = new JsonRpcServerImplementation(null, null);
            JsonRpcRequest request = jsonRpcServer.ExposeDeserializeJsonRpcRequest(content);

            InitializeParams paramss = request.Parameters.ToObject<InitializeParams>();

            Assert.AreEqual("initialize", request.Method);
        }
    }
}
