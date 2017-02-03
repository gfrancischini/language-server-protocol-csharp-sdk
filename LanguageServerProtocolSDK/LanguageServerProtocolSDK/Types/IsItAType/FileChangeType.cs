using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * The file event type
     */
    enum FileChangeType
    {
        /**
         * The file got created.
         */
        Created = 1,
        /**
         * The file got changed.
         */
        Changed = 2,
        /**
         * The file got deleted.
         */
        Deleted = 3
    }
}
