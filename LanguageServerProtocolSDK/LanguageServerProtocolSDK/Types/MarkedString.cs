using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    /**
     * MarkedString can be used to render human readable text. It is either a markdown string
     * or a code-block that provides a language and a code snippet. The language identifier
     * is sematically equal to the optional language identifier in fenced code blocks in GitHub
     * issues. See https://help.github.com/articles/creating-and-highlighting-code-blocks/#syntax-highlighting
     *
     * The pair of a language and a value is an equivalent to markdown:
     * ```${language}
     * ${value}
     * ```
     *
     * Note that markdown strings will be sanitized - that means html will be escaped.
     */
    public class MarkedString
    {
        [JsonProperty(PropertyName = "language")]
        public string Language
        {
            get;
            set;
        }

        [JsonProperty(PropertyName = "value")]
        public string Value
        {
            get;
            set;
        }
    }
}
