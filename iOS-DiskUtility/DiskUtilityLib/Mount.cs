namespace DiskUtilityLib
{
    public class Mount
    {
        public string HFS(string DiskDevice, string MountPoint)
        {
            return "mount_hfs " + DiskDevice + " " + MountPoint;
        }
    }
}
