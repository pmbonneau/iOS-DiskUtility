using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskUtilityUI
{
    interface ISecureShell
    {
        void ExecuteRemoteCommand(string CommandToExecute);
        string ExecuteRemoteCommandWithOutput(string CommandToExecute);
    }
}
