using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * A document link is a range in a text document that links to an internal or external resource, like another
     * text document or a web site.
     */
    class DocumentLink
    {

        /**
         * The range this link applies to.
         */
        [JsonProperty(PropertyName = "range")]
        Range Range
        {
            get;
            set;
        }

        /**
         * The uri this link points to.
         */
        [JsonProperty(PropertyName = "target")]
        string Target
        {
            get;
            set;
        }

        public DocumentLink()
        {

        }
    }
}
