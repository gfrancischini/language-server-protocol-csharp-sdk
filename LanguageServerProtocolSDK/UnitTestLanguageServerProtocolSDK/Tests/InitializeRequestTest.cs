using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using LanguageServerProtocolSDK.Protocol;
using Newtonsoft.Json;
using LanguageServerProtocolSDK.JsonRpc;
using UnitTestLanguageServerProtocolSDK.Utils;

namespace UnitTestLanguageServerProtocolSDK.Tests
{
    [TestClass]
    public class InitializeRequestTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string content = Utilities.LoadFile("Initialize", "request", "method_initialize_1.json");
            JsonRpcRequest request = JsonConvert.DeserializeObject<JsonRpcRequest>(content);

        }



    }
}
