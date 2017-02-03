using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using LanguageServerProtocolSDK.Protocol;
using LanguageServerProtocolSDK.JsonRpc;
using UnitTestLanguageServerProtocolSDK.Implementations;
using UnitTestLanguageServerProtocolSDK.Utils;

namespace UnitTestLanguageServerProtocolSDK.Tests
{
    [TestClass]
    public class LanguageServerProtocolSDKTest
    {
        [TestMethod]
        public void TestInitializeMethod()
        {
            string requestMessage = Utilities.LoadFile("initialize", "Request", "method_initialize_1.json");
            string responseMessage = Utilities.LoadFile("initialize", "Response", "method_initialize_1.json");
            JsonRpcResponse expectedResponse = JsonConvert.DeserializeObject<JsonRpcResponse>(responseMessage);

            LanguageServerProtocolImplementation server = new LanguageServerProtocolImplementation(null, null);
            JsonRpcResponse response = server.ExposeProcessMessage(requestMessage);

            Assert.AreEqual(JsonConvert.SerializeObject(expectedResponse), JsonConvert.SerializeObject(response));
        }
    }
}
