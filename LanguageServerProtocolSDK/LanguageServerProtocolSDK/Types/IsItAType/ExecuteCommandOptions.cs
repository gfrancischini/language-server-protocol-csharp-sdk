using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageServerProtocolSDK.Types
{
    /// <summary>
    /// Execute command options.
    /// </summary>
    public class ExecuteCommandOptions
    {
        /// <summary>
        /// The commands to be executed on the server
        /// </summary>
        List<String> Commands
        {
            get;
            set;
        }

        public ExecuteCommandOptions()
        {
            this.Commands = new List<string>();
        }

        public ExecuteCommandOptions(List<string> commands)
        {
            this.Commands = commands;
        }
    }
}
