using LanguageServerProtocolSDK.Protocol.Base;
using LanguageServerProtocolSDK.Types;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.Document
{
    public class TextDocumentHoverResult : BaseResult
    {
        Hover Hover;

        public override JObject ToJObject()
        {
            return JObject.FromObject(Hover);
        }
    }
}
