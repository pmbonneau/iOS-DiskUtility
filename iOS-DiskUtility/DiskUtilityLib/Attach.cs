namespace DiskUtilityLib
{
    public class Attach
    {
        public string LinkToDiskDevice(string DiskImagePath)
        {
            return "attach " + DiskImagePath;
        }
    }
}
