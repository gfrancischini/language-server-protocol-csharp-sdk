using LanguageServerProtocolSDK.Protocol.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    /**
 * Represents a collection of [completion items](#CompletionItem) to be presented
 * in the editor.
 */
    public class CompletionList
    {
        /**
         * This list it not complete. Further typing should result in recomputing
         * this list.
         */
        [JsonProperty(PropertyName = "isIncomplete")]
        public bool IsIncomplete
        {
            get;
            set;
        }
        /**
         * The completion items.
         */
        [JsonProperty(PropertyName = "items")]
        public List<CompletionItem> items
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new completion list.
        /// </summary>
        /// <param name="items">items The completion items.</param>
        /// <param name="IsIncomplete">isIncomplete The list is not complete.</param>
        public CompletionList(List<CompletionItem> items, bool isIncomplete)
        {
            this.items = items;
            this.IsIncomplete = isIncomplete;
        }

        public CompletionList(List<CompletionItem> items)
        {
            this.items = items;
        }

        public CompletionList()
        {
            this.items = new List<CompletionItem>();
        }
    }
}
