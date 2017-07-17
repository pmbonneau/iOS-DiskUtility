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
            return "echo -e \"/dev/rdisk0s1\ni\n" + PartitionNumber + "\n\" | gptfdisk";
        }

        public string getConsoleOutputPartitionInfo(string PartitionNumber)
        {
            return "echo -e \"/dev/rdisk0s1\ni\n" + PartitionNumber + "\n\" | gptfdisk";
        }

        public string ExpandPartitionTable(string MaxEntries)
        {
            return "echo -e \"/dev/rdisk0s1\nx\ns\n" + MaxEntries + "\nm\nw\ny\" | gptfdisk";
        }

        public string CreateNewPartition(string PartitionName, string PartitionNumber, int FirstSector, long NewSizeInMB)
        {
            long NewPartitionSectorsLength = (NewSizeInMB * 1024 * 1024) / FileSystemBlockSize;
            int EndSector = FirstSector + Convert.ToInt32(NewPartitionSectorsLength);
            return "echo -e \"/dev/rdisk0s1\nx\ns\n\nm\nn\n\n\n" + Convert.ToString(EndSector) + "\n\nc\n" + PartitionNumber + "\n" + PartitionName + "\nw\ny\" | gptfdisk";
        }

        public string AdjustDeviceDataPartition(int FirstSector, long NewSizeInMB, string PartitionUniqueGUID)
        {
            long NewPartitionSectorsLength = (NewSizeInMB * 1024 * 1024) / FileSystemBlockSize;
            int EndSector = FirstSector + Convert.ToInt32(NewPartitionSectorsLength);

            return "echo -e \"/dev/rdisk0s1\nd\n2\nn\n\n" + Convert.ToString(EndSector) + "\n\nc\n2\nData\nx\na\n2\n48\n49\n\nc\n2\n" + PartitionUniqueGUID +"\nm\nw\ny\" | gptfdisk";
        }

        public string SetPartitionAttributes(string PartitionNumber, string AttributID)
        {
            return "echo -e \"/dev/rdisk0s1\nx\na\n" + PartitionNumber + "\n" + AttributID + "\n\nm\nw\ny\" | gptfdisk";
        }

        public string DeletePartition(string PartitionNumber)
        {
            return "echo -e \"/dev/rdisk0s1\nd\n" + PartitionNumber + "\nw\ny\" | gptfdisk";
        }
    }
}
