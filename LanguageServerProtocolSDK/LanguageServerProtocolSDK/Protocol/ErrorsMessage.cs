using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol
{
    /// <summary>
    /// Class with the common message errors
    /// </summary>
    public class ErrorsMessage
    {
        #region Error Messages
        public const string RequiredMethodResponse = "The method {0} should respond to the request. Request id {1}";
        public const string UnrecognizedRequest = "Unreconized method {0} request. Request id {1}";
        public const string ErrorProcessingRequest = "Error while processing method {0}. Request id {1}. Exception {2}";
        #endregion

        #region Methods
        public static string GetRequiredMethodResponse(string method, int id)
        {
            return String.Format(RequiredMethodResponse, method, id);
        }

        public static string GetUnrecognizedRequest(string method, int id)
        {
            return String.Format(UnrecognizedRequest, method, id);
        }

        public static string GetErrorProcessingRequest(string method, int id, string exception)
        {
            return String.Format(ErrorProcessingRequest, method, id, exception);
        }
        #endregion

    }
}
