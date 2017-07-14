using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskUtilityLib
{
    public class HFSResize
    {
        public string ResizeHFS(string MountPoint, long NewSizeInMB)
        {
            long NewSizeInBytes = NewSizeInMB * 1024 * 1024;
            string NewSizeArg = Convert.ToString(NewSizeInBytes);

            return "hfs_resize " + MountPoint + " " + NewSizeArg;          
        }
    }
}
