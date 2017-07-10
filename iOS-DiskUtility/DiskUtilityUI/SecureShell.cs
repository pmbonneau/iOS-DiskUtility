using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinSCP;

namespace DiskUtilityUI
{
    public class SecureShell
    {
        public SessionOptions sessionOptions;
        public Session session;
        public SecureShell()
        {
            try
            {
                sessionOptions = new SessionOptions
                {
                    Protocol = Protocol.Sftp,
                    HostName = "192.168.32.20",
                    UserName = "root",
                    Password = "alpine"
                };

                sessionOptions.GiveUpSecurityAndAcceptAnySshHostKey = true;

                session = new Session();
                session.Open(sessionOptions);

                return;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
                return;
            }
        }

        public void ExecuteRemoteCommand(string CommandToExecute)
        {
            session.ExecuteCommand(CommandToExecute).Check();
        }

        public string ExecuteRemoteCommandWithOutput(string CommandToExecute)
        {
            return session.ExecuteCommand(CommandToExecute).Output;
        }
    }
}
