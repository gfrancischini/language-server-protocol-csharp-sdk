using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * A document highlight kind.
     */
    enum DocumentHighlightKind
    {
        /**
         * A textual occurrance.
         */
        Text = 1,

        /**
         * Read-access of a symbol, like reading a variable.
         */
        Read = 2,

        /**
         * Write-access of a symbol, like writing to a variable.
         */
        Write = 3
    }
}
