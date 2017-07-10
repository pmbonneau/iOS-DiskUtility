using System;
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
            string PartitionUniqueGUID;
            string CommandOutput = "";
            int PositionUniqueGUID;
            CommandOutput = SSH.ExecuteRemoteCommandWithOutput(GPTfdiskEditor.getConsoleOutputPartitionUniqueGUID("2"));
            PositionUniqueGUID = CommandOutput.IndexOf("GUID", CommandOutput.IndexOf("GUID")+1);
            PartitionUniqueGUID = CommandOutput.Substring(PositionUniqueGUID + 6, 36);

        }

        private void btnDeletePartition_Click(object sender, EventArgs e)
        {
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.DeletePartition(txtPartitionToDelete.Text));
        }

        private void btnCreatePartition_Click(object sender, EventArgs e)
        {
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            string PartitionLastSector = SSH.ExecuteRemoteCommandWithOutput(GPTfdiskEditor.getConsoleOutputPartitionEndSector("2"));

        }

        private void btnExtendPartitionTable_Click(object sender, EventArgs e)
        {
            GPTfdisk GPTfdiskEditor = new GPTfdisk();
            SSH.ExecuteRemoteCommand(GPTfdiskEditor.ExpandPartitionTable(txtMaxEntries.Text));
        }
    }
}
