﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * Represents reasons why a text document is saved.
     */
    enum TextDocumentSaveReason
    {

        /**
         * Manually triggered, e.g. by the user pressing save, by starting debugging,
         * or by an API call.
         */
        Manual = 1,

        /**
         * Automatic after a delay.
         */
        AfterDelay = 2,

        /**
         * When the editor lost focus.
         */
        FocusOut = 3,
    }
}
