using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskUtilityLib
{
    public class GPTfdisk
    {
        public int FileSystemBlockSize {get; set;}

        public GPTfdisk()
        {

        }

        public GPTfdisk(int pFileSystemBlockSize)
        {
            FileSystemBlockSize = pFileSystemBlockSize;
        }

        public string getConsoleOutputPartitionUniqueGUID(string PartitionNumber)
        {
            return "echo -e \"/dev/rdisk0s1\ni\n2\n\" | gptfdisk";
        }

        public string getConsoleOutputPartitionEndSector(string PartitionNumber)
        {
            return "echo -e \"/dev/rdisk0s1\nn\n\" | gptfdisk";
        }

        public string ExpandPartitionTable(string MaxEntries)
        {
            return "echo -e \"/dev/rdisk0s1\nx\ns\n" + MaxEntries + "\nw\ny\" | gptfdisk";
        }

        public string CreateNewPartition(string PartitionName, string PartitionNumber, int FirstSector, int NewSizeInMB)
        {
            int NewPartitionSectorsLength = (NewSizeInMB * 1024 * 1024) / FileSystemBlockSize;
            int EndSector = FirstSector + NewPartitionSectorsLength;
            return "echo -e \"/dev/rdisk0s1\nn\n\n" + Convert.ToString(EndSector) + "\n\nc\n" + PartitionNumber + "\n" + PartitionName + "\nw\ny" + " | gptfdisk";
        }

        public string CreateNewPartition(string PartitionNumber, int NewSizeInMB, string PartitionUniqueGUID)
        {
            return "";
        }

        public string DeletePartition(string PartitionNumber)
        {
            return "echo -e \"/dev/rdisk0s1\nd\n" + PartitionNumber + "\nw\ny\" | gptfdisk";
        }
    }
}
