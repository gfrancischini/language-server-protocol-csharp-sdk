using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{

    /// <summary>
    /// Represents a reference to a command. Provides a title which
    /// will be used to represent a command in the UI and, optionally,
    /// an array of arguments which will be passed to the command handler
    /// function when invoked.
    /// </summary>
    class Command
    {
        /**
         * Title of the command, like `save`.
         */
        [JsonProperty(PropertyName = "title")]
        string Title
        {
            get;
            set;
        }

        /**
         * The identifier of the actual command handler.
         */
        [JsonProperty(PropertyName = "command")]
        string CommandName
        {
            get;
            set;
        }

        /**
         * Arguments that the command handler should be
         * invoked with.
         */
        [JsonProperty(PropertyName = "arguments")]
        List<Object> Arguments
        {
            get;
            set;
        }

        /// <summary>
        /// 
        /// </summary>
        public Command()
        {
            this.Arguments = new List<object>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="arguments"></param>
        public Command(List<object> arguments)
        {
            this.Arguments = arguments;
        }
    }
}
