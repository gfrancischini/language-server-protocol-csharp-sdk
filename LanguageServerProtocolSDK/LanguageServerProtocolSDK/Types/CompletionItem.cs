using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    public class CompletionItem
    {
        /**
         * The label of this completion item. By default
         * also the text that is inserted when selecting
         * this completion.
         */
        [JsonProperty(PropertyName = "label")]
        public string Label
        {
            get;
            set;
        }

        /**
         * The kind of this completion item. Based of the kind
         * an icon is chosen by the editor.
         */
        [JsonProperty(PropertyName = "kind")]
        public CompletionItemKind Kind
        {
            get;
            set;
        }

        /**
         * A human-readable string with additional information
         * about this item, like type or symbol information.
         */
        [JsonProperty(PropertyName = "detail")]
        public string Detail
        {
            get;
            set;
        }

        /**
         * A human-readable string that represents a doc-comment.
         */
        [JsonProperty(PropertyName = "documentation")]
        public string Documentation
        {
            get;
            set;
        }

        /**
         * A string that shoud be used when comparing this item
         * with other items. When `falsy` the label is used.
         */
        [JsonProperty(PropertyName = "sortText")]
        public string SortText
        {
            get;
            set;
        }

        /**
         * A string that should be used when filtering a set of
         * completion items. When `falsy` the label is used.
         */
        [JsonProperty(PropertyName = "filterText")]
        public string FilterText
        {
            get;
            set;
        }

        /**
         * A string that should be inserted a document when selecting
         * this completion. When `falsy` the label is used.
         */
        [JsonProperty(PropertyName = "insertText")]
        public string InsertText
        {
            get;
            set;
        }


        /**
         * An edit which is applied to a document when selecting
         * this completion. When an edit is provided the value of
         * insertText is ignored.
         */
        [JsonProperty(PropertyName = "textEdit")]
        TextEdit TextEdit
        {
            get;
            set;
        }

        /**
          * An optional array of additional [text edits](#TextEdit) that are applied when
          * selecting this completion. Edits must not overlap with the main [edit](#CompletionItem.textEdit)
          * nor with themselves.
          */
        [JsonProperty(PropertyName = "additionalTextEdits")]
        TextEdit[] AdditionalTextEdits
        {
            get;
            set;
        }

        /**
         * An optional [command](#Command) that is executed *after* inserting this completion. *Note* that
         * additional modifications to the current document should be described with the
         * [additionalTextEdits](#CompletionItem.additionalTextEdits)-property.
         */
        [JsonProperty(PropertyName = "command")]
        Command Command
        {
            get;
            set;
        }

        /**
         * An data entry field that is preserved on a completion item between
         * a [CompletionRequest](#CompletionRequest) and a [CompletionResolveRequest]
         * (#CompletionResolveRequest)
         */
        [JsonProperty(PropertyName = "data")]
        Object Data
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="kind"></param>
        /// <param name="detail"></param>
        public CompletionItem(string label, CompletionItemKind kind, string detail)
        {
            this.Label = label;
            this.Kind = kind;
            this.Detail = detail;
        }

        public CompletionItem()
        {

        }
    }
}
