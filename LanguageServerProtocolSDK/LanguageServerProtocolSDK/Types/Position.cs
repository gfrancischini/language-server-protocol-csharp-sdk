using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    /// <summary>
    /// Position in a text document expressed as zero-based line and character offset.
    /// </summary>
    public class Position
    {

        /// <summary>
        /// Line position in a document (zero-based).
        /// </summary>
        [JsonProperty(PropertyName = "line")]
        public int Line
        {
            get;
            set;
        }

        /// <summary>
        /// Character offset on a line in a document (zero-based). Assuming that the line is
        ///  `character` and `character + 1`. Given the following line: 'a𐐀c', character 0 is
        /// the gap between the start of the start and 'a' ('|a𐐀c'), character 1 is the gap
        /// between 'a' and '𐐀' ('a|𐐀c') and character 2 is the gap between '𐐀' and 'b' ('a𐐀|c').
        /// 
        /// The string 'a𐐀c' consist of 3 characters with valid character values being 0, 1, 2, 3
        /// for that string. Note that the string encoded in UTF-16 is encoded using 4 code units
        /// (the 𐐀 is encoded using two code units). The character offset is therefore encoding
        /// independent.
        /// </summary>
        [JsonProperty(PropertyName = "character")]
        public int Character
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <param name="character"></param>
        public Position(int line, int character)
        {
            this.Line = line;
            this.Character = character;
        }

        public Position()
        {

        }
    }





}
