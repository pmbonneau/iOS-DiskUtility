﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiskUtilityLib;

namespace DiskUtilityUI
{
    public partial class frmMain : Form
    {
        SecureShell SSH;
        int PartitionCount = 2;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnConnectDevice_Click(object sender, EventArgs e)
        {
            SSH = new SecureShell();
        }

        private void btnResizeHFS_Click(object sender, EventArgs e)
        {
            HFSResize HFSResizer = new HFSResize();
            SSH.ExecuteRemoteCommand(HFSResizer.ResizeHFS("/private/var/",Convert.ToInt16(txtDataPartitionNewSize.Text)));
        }

        private void btnPrepareGPT_Click(object sender, EventArgs e)
        {
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            GPTfdiskEditor.FileSystemBlockSize = 8192;
            string PartitionUniqueGUID;
            string PartitionFirstSectorTempString;
            int PartitionFirstSector;
            string CommandOutput = "";
            int PositionUniqueGUID;
            int PositionFirstSector;
            CommandOutput = SSH.ExecuteRemoteCommandWithOutput(GPTfdiskEditor.getConsoleOutputPartitionUniqueGUID("2"));
            PositionUniqueGUID = CommandOutput.IndexOf("GUID", CommandOutput.IndexOf("GUID")+1);
            PartitionUniqueGUID = CommandOutput.Substring(PositionUniqueGUID + 6, 36);
            CommandOutput = SSH.ExecuteRemoteCommandWithOutput(GPTfdiskEditor.getConsoleOutputPartitionInfo("2"));
            PositionFirstSector = CommandOutput.IndexOf("First");
            PartitionFirstSectorTempString = CommandOutput.Substring(PositionFirstSector + 14, 7);
            PartitionFirstSector = Convert.ToInt32(PartitionFirstSectorTempString.TrimEnd());
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.AdjustDeviceDataPartition(PartitionFirstSector, 8000, PartitionUniqueGUID));
        }

        private void btnDeletePartition_Click(object sender, EventArgs e)
        {
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.DeletePartition(txtPartitionToDelete.Text));
            PartitionCount--;
        }

        private void btnCreatePartition_Click(object sender, EventArgs e)
        {
            PartitionCount++;
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            GPTfdiskEditor.FileSystemBlockSize = 8192;
            string PartitionLastSectorTempString;
            int PartitionLastSector;
            string CommandOutput = "";
            int PositionLastSector;
            CommandOutput = SSH.ExecuteRemoteCommandWithOutput(GPTfdiskEditor.getConsoleOutputPartitionInfo(Convert.ToString(PartitionCount - 1)));
            PositionLastSector = CommandOutput.IndexOf("Last");
            PartitionLastSectorTempString = CommandOutput.Substring(PositionLastSector + 13, 7);
            PartitionLastSector = Convert.ToInt32(PartitionLastSectorTempString.TrimEnd());
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.CreateNewPartition(txtPartitionName.Text, Convert.ToString(PartitionCount), PartitionLastSector, Convert.ToInt32(txtNewPartitionSize.Text)));
        }

        private void btnExtendPartitionTable_Click(object sender, EventArgs e)
        {
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.ExpandPartitionTable(txtMaxEntries.Text));
        }
    }
}
