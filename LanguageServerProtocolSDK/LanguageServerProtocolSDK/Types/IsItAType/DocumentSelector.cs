using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    class DocumentSelector
    {
        List<DocumentFilter> DocumentFilter
        {
            get;
            set;
        }

        public DocumentSelector()
        {
            this.DocumentFilter = new List<DocumentFilter>();
        }
    }
}
