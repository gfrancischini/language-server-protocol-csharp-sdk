using LanguageServerProtocolSDK.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.JsonRpc
{
    /// <summary>
    /// An JSON RPC Server
    /// </summary>
    public abstract class JsonRpcServer
    {
        #region Variables

        /// <summary>
        /// Print request to the console output
        /// </summary>
        public bool TRACE_REQUEST;

        /// <summary>
        /// Print response to the console output
        /// </summary>
        public bool TRACE_RESPONSE;

        /// <summary>
        /// 
        /// </summary>
        protected const int BUFFER_SIZE = 4096;

        /// <summary>
        /// 
        /// </summary>
        protected const string TWO_CRLF = "\r\n\r\n";

        /// <summary>
        /// 
        /// </summary>
        protected static readonly Regex CONTENT_LENGTH_MATCHER = new Regex(@"Content-Length: (\d+)");

        /// <summary>
        /// 
        /// </summary>
        protected static readonly Encoding Encoding = System.Text.Encoding.UTF8;

        /// <summary>
        /// 
        /// </summary>
        private Stream _outputStream;

        private Stream _inputStream;

        /// <summary>
        /// 
        /// </summary>
        private ByteBuffer _rawData;

        /// <summary>
        /// 
        /// </summary>
        private int _bodyLength;

        /// <summary>
        /// 
        /// </summary>
        private bool _stopRequested;

        #endregion

        #region Constructor
        /// <summary>
        /// Create a new JsonRpcServer Insance
        /// </summary>
        /// <param name="inputStream">Stream for incoming data</param>
        /// <param name="outputStream">Stream for outcoming data</param>
        public JsonRpcServer(Stream inputStream, Stream outputStream)
        {
            _outputStream = outputStream;
            _inputStream = inputStream;
            _bodyLength = -1;
            _rawData = new ByteBuffer();
        }

        #endregion

        #region Methods

        /// <summary>
        /// Start the JsonRpcServer
        /// </summary>
        /// <returns></returns>
        public async Task Start()
        {
            byte[] buffer = new byte[BUFFER_SIZE];
            _stopRequested = false;

            while (!_stopRequested)
            {
                var read = await _inputStream.ReadAsync(buffer, 0, buffer.Length);

                // append raw data to byte buffer
                if (read > 0)
                {
                    _rawData.Append(buffer, read);
                    ProcessRawData();
                }
            }
        }

        public void Stop()
        {
            _stopRequested = true;
        }


        /// <summary>
        /// Process incoming raw data
        /// </summary>
        protected void ProcessRawData()
        {
            while (true)
            {
                // check if there is data to process
                if (_bodyLength >= 0)
                {
                    if (_rawData.Length >= _bodyLength)
                    {
                        var buf = _rawData.RemoveFirst(_bodyLength);

                        _bodyLength = -1;

                        JsonRpcResponse response = this.ProcessMessage(Encoding.GetString(buf));
                        if (response != null)
                        {
                            this.SendMessage(response);
                        }
                        continue;   // there may be more complete messages to process
                    }
                }
                else
                {
                    string s = _rawData.GetString(Encoding);
                    var idx = s.IndexOf(TWO_CRLF);
                    if (idx != -1)
                    {
                        Match m = CONTENT_LENGTH_MATCHER.Match(s);
                        if (m.Success && m.Groups.Count == 2)
                        {
                            _bodyLength = Convert.ToInt32(m.Groups[1].ToString());

                            _rawData.RemoveFirst(idx + TWO_CRLF.Length);

                            continue;   // try to handle a complete message
                        }
                    }
                }
                break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected JsonRpcRequest DeserializeJsonRpcRequest(string message)
        {
            //deserialize the request object
            JsonRpcRequest request = JsonConvert.DeserializeObject<JsonRpcRequest>(message);
            return request;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="req"></param>
        protected JsonRpcResponse ProcessMessage(string message)
        {
            JsonRpcRequest request = this.DeserializeJsonRpcRequest(message);
            if (request != null)
            {
                if (TRACE_REQUEST)
                {
                    Console.Out.WriteLine(string.Format("REQUEST {0}: {1}", request.Method, JsonConvert.SerializeObject(request.Parameters)));
                }


                // process the request and get the response message
                var response = this.ProcessRequest(request);
                if (response != null)
                {
                    return response;
                }
                return null;

            }
            return null;
        }


        /// <summary>
        /// Send the message that is already serialized
        /// </summary>
        /// <param name="message">The message serialized to send</param>
        protected void SendMessage(string message)
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.AppendLine(String.Format("Content-Length: {0}", message.Length));
            strBuilder.AppendLine(String.Format("Content-Type: {0}", "application/vscode-jsonrpc; charset=utf8"));
            strBuilder.AppendLine("");
            strBuilder.Append(message);

            byte[] requestBinary = Encoding.UTF8.GetBytes(strBuilder.ToString());

            try
            {
                _outputStream.Write(requestBinary, 0, requestBinary.Length);
                _outputStream.Flush();
            }
            catch (Exception e)
            {
                //Error sending message.. what to do here?
                throw e;
            }
        }

        /// <summary>
        /// Serialize the message and send
        /// </summary>
        /// <param name="message">The JsonRPC Message</param>
        protected void SendMessage(JsonRpcMessage message)
        {
            if (TRACE_RESPONSE)
            {
                Console.Error.WriteLine(string.Format(" R: {0}", JsonConvert.SerializeObject(message)));
            }

            string body = JsonConvert.SerializeObject(message);

            SendMessage(body);
        }
        #endregion


        #region Abstract Methods

        /// <summary>
        /// Abstrac method that should return the response
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        protected abstract JsonRpcResponse ProcessRequest(JsonRpcRequest request);

        #endregion

    }
}
