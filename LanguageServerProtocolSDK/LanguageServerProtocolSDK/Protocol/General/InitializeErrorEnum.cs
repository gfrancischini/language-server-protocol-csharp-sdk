using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.General
{

    /// <summary>
    /// Known error codes for an `InitializeError`;
    /// </summary>
    enum InitializeErrorEnum
    {
        /// <summary>
        /// If the protocol version provided by the client can't be handled by the server.
        /// </summary>
        unknownProtocolVersion = 1
    }
}
