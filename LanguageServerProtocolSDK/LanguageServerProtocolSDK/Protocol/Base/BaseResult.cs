using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Protocol.Base
{
    public class BaseResult
    {
        public virtual JObject ToJObject()
        {
            return JObject.FromObject(this);
        }
    }
}
