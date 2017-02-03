using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    /// <summary>
    /// Represents a location inside a resource, such as a line inside a text file.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// The location's uri
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri;

        /// <summary>
        /// The location's range
        /// </summary>
        [JsonProperty(PropertyName = "range")]
        public Range Range;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uri">The location's uri</param>
        /// <param name="range">The location's range</param>
        public Location(string uri, Range range)
        {
            this.Uri = uri;
            this.Range = range;
        }

        public Location()
        {

        }
    }
}
