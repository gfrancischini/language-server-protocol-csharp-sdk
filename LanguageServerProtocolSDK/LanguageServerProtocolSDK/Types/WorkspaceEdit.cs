using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /**
     * A workspace edit represents changes to many resources managed
     * in the workspace.
     */
    class WorkspaceEdit
    {
        [JsonProperty(PropertyName = "changes")]
        List<TextDocumentEdit> Changes
        {
            get;
            set;
        }

        public WorkspaceEdit()
        {
            this.Changes = new List<TextDocumentEdit>();
        }

        public WorkspaceEdit(List<TextDocumentEdit> changes)
        {
            this.Changes = changes;
        }
    }
}
