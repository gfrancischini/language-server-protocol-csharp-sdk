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
    public class TextDocumentFormattingResult : BaseResult
    {
        List<TextEdit> TextEditList;

        public override JObject ToJObject()
        {
            return JObject.FromObject(TextEditList);
        }
    }
}
