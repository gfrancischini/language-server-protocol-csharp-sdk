using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * A document filter denotes a document by different properties like
     * the [language](#TextDocument.languageId), the [scheme](#Uri.scheme) of
     * its resource, or a glob-pattern that is applied to the [path](#TextDocument.fileName).
     *
     * @sample A language filter that applies to typescript files on disk: `{ language: 'typescript', scheme: 'file' }`
     * @sample A language filter that applies to all package.json paths: `{ language: 'json', pattern: '**package.json' }`
     */
    public class DocumentFilter
    {
        /**
         * A language id, like `typescript`.
         */
        [JsonProperty(PropertyName = "language")]
        string Language
        {
            get;
            set;
        }

        /**
         * A Uri [scheme](#Uri.scheme), like `file` or `untitled`.
         */
        [JsonProperty(PropertyName = "scheme")]
        string Scheme
        {
            get;
            set;
        }

        /**
         * A glob pattern, like `*.{ts,js}`.
         */
        [JsonProperty(PropertyName = "pattern")]
        string Pattern
        {
            get;
            set;
        }
    }
}
