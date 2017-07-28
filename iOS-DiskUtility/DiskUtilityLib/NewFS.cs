using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskUtilityLib
{
    public class NewFS
    {
        public string HFS(string VolumeName, string NandBlockSize, string TargetDiskDevice, bool JournaledFlag, bool ProtectedFlag)
        {
            string command = "newfs_hfs -s -v " + VolumeName;
            if (JournaledFlag == true)
            {
                command = command + " -J";
            }

            if (ProtectedFlag == true)
            {
                command = command + " -P";
            }

            command = command + " -b " + NandBlockSize + " -n a=" + NandBlockSize + ",c=" + NandBlockSize + ",e=" + NandBlockSize + " " + TargetDiskDevice;
            return command;
        }
    }
}
