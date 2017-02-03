using LanguageServerProtocolSDK.Protocol;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDKConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is used to wait the debugger attach
#if DEBUG
            while (!Debugger.IsAttached)
            {
                Thread.Sleep(100);
            }
#endif

            // create e new Samples Language Server Protocol
            SampleLanguageServer languageServerProtocol = new SampleLanguageServer(Console.OpenStandardInput(), Console.OpenStandardOutput());
            languageServerProtocol.TRACE_REQUEST = false;
            languageServerProtocol.TRACE_RESPONSE = false;

            // start the server and wait execution until kill
            languageServerProtocol.Start().Wait();
        }

    }
}
