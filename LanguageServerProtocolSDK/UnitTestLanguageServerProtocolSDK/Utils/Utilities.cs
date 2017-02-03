using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLanguageServerProtocolSDK.Utils
{
    public class Utilities
    {
        public static string LoadFile(string module, string type, string name)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "Messages", module, type, name);
            return File.ReadAllText(filePath);
        }
    }
}
