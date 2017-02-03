using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    /// <summary>
    /// A range in a text document expressed as (zero-based) start and end positions.
    /// </summary>
    public class Range
    {
        /// <summary>
        /// The range's start position
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public Position Start;

        /// <summary>
        /// The range's end position
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public Position End;

        public Range(Position start, Position end)
        {
            this.Start = start;
            this.End = end;
        }

        public Range()
        {

        }
    }
}
