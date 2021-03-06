﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * A code lens represents a [command](#Command) that should be shown along with
     * source text, like the number of references, a way to run tests, etc.
     *
     * A code lens is _unresolved_ when no command is associated to it. For performance
     * reasons the creation of a code lens and resolving should be done to two stages.
     */
    class CodeLens
    {
        /// <summary>
        /// The range in which this code lens is valid. Should only span a single line.
        /// </summary>
        [JsonProperty(PropertyName = "range")]
        Range range
        {
            get;
            set;
        }

        /// <summary>
        /// The command this code lens represents.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        Command command
        {
            get;
            set;
        }

        /// <summary>
        /// An data entry field that is preserved on a code lens item between
        /// a [CodeLensRequest](#CodeLensRequest) and a [CodeLensResolveRequest]
        /// (#CodeLensResolveRequest)
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        Object data
        {
            get;
            set;
        }
    }
}
