using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// The diagnostic's serverity.
    /// </summary>
    public enum DiagnosticSeverity
    {
        /**
         * Reports an error.
         */
        Error = 1,
        /**
         * Reports a warning.
         */
        Warning = 2,
        /**
         * Reports an information.
         */
        Information = 3,
        /**
         * Reports a hint.
         */
        Hint = 4
    }
}
