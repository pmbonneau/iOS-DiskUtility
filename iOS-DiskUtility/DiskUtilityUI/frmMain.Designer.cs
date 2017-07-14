namespace DiskUtilityUI
{
    partial class frmMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResizeHFS = new System.Windows.Forms.Button();
            this.btnConnectDevice = new System.Windows.Forms.Button();
            this.lblDataPartitionSize = new System.Windows.Forms.Label();
            this.txtDataPartitionNewSize = new System.Windows.Forms.TextBox();
            this.btnPrepareGPT = new System.Windows.Forms.Button();
            this.btnCreatePartition = new System.Windows.Forms.Button();
            this.lblNewPartitionSize = new System.Windows.Forms.Label();
            this.txtNewPartitionSize = new System.Windows.Forms.TextBox();
            this.btnDeletePartition = new System.Windows.Forms.Button();
            this.lblPartitionToDelete = new System.Windows.Forms.Label();
            this.txtPartitionToDelete = new System.Windows.Forms.TextBox();
            this.lblPartitionName = new System.Windows.Forms.Label();
            this.txtPartitionName = new System.Windows.Forms.TextBox();
            this.btnExtendPartitionTable = new System.Windows.Forms.Button();
            this.lblMaxEntries = new System.Windows.Forms.Label();
            this.txtMaxEntries = new System.Windows.Forms.TextBox();
            this.lblDeviceIpAddress = new System.Windows.Forms.Label();
            this.txtDeviceIpAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnResizeHFS
            // 
            this.btnResizeHFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResizeHFS.Location = new System.Drawing.Point(12, 78);
            this.btnResizeHFS.Name = "btnResizeHFS";
            this.btnResizeHFS.Size = new System.Drawing.Size(158, 45);
            this.btnResizeHFS.TabIndex = 0;
            this.btnResizeHFS.Text = "Resize HFS";
            this.btnResizeHFS.UseVisualStyleBackColor = true;
            this.btnResizeHFS.Click += new System.EventHandler(this.btnResizeHFS_Click);
            // 
            // btnConnectDevice
            // 
            this.btnConnectDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectDevice.Location = new System.Drawing.Point(12, 12);
            this.btnConnectDevice.Name = "btnConnectDevice";
            this.btnConnectDevice.Size = new System.Drawing.Size(158, 45);
            this.btnConnectDevice.TabIndex = 1;
            this.btnConnectDevice.Text = "Connect to Device";
            this.btnConnectDevice.UseVisualStyleBackColor = true;
            this.btnConnectDevice.Click += new System.EventHandler(this.btnConnectDevice_Click);
            // 
            // lblDataPartitionSize
            // 
            this.lblDataPartitionSize.AutoSize = true;
            this.lblDataPartitionSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPartitionSize.Location = new System.Drawing.Point(195, 94);
            this.lblDataPartitionSize.Name = "lblDataPartitionSize";
            this.lblDataPartitionSize.Size = new System.Drawing.Size(178, 16);
            this.lblDataPartitionSize.TabIndex = 2;
            this.lblDataPartitionSize.Text = "Data partition new size (MB) :";
            // 
            // txtDataPartitionNewSize
            // 
            this.txtDataPartitionNewSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPartitionNewSize.Location = new System.Drawing.Point(379, 91);
            this.txtDataPartitionNewSize.Name = "txtDataPartitionNewSize";
            this.txtDataPartitionNewSize.Size = new System.Drawing.Size(122, 22);
            this.txtDataPartitionNewSize.TabIndex = 3;
            // 
            // btnPrepareGPT
            // 
            this.btnPrepareGPT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrepareGPT.Location = new System.Drawing.Point(12, 144);
            this.btnPrepareGPT.Name = "btnPrepareGPT";
            this.btnPrepareGPT.Size = new System.Drawing.Size(158, 45);
            this.btnPrepareGPT.TabIndex = 4;
            this.btnPrepareGPT.Text = "Prepare GPT";
            this.btnPrepareGPT.UseVisualStyleBackColor = true;
            this.btnPrepareGPT.Click += new System.EventHandler(this.btnPrepareGPT_Click);
            // 
            // btnCreatePartition
            // 
            this.btnCreatePartition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePartition.Location = new System.Drawing.Point(12, 212);
            this.btnCreatePartition.Name = "btnCreatePartition";
            this.btnCreatePartition.Size = new System.Drawing.Size(158, 45);
            this.btnCreatePartition.TabIndex = 5;
            this.btnCreatePartition.Text = "Create Partition";
            this.btnCreatePartition.UseVisualStyleBackColor = true;
            this.btnCreatePartition.Click += new System.EventHandler(this.btnCreatePartition_Click);
            // 
            // lblNewPartitionSize
            // 
            this.lblNewPartitionSize.AutoSize = true;
            this.lblNewPartitionSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPartitionSize.Location = new System.Drawing.Point(195, 226);
            this.lblNewPartitionSize.Name = "lblNewPartitionSize";
            this.lblNewPartitionSize.Size = new System.Drawing.Size(71, 16);
            this.lblNewPartitionSize.TabIndex = 6;
            this.lblNewPartitionSize.Text = "Size (MB) :";
            // 
            // txtNewPartitionSize
            // 
            this.txtNewPartitionSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPartitionSize.Location = new System.Drawing.Point(272, 223);
            this.txtNewPartitionSize.Name = "txtNewPartitionSize";
            this.txtNewPartitionSize.Size = new System.Drawing.Size(71, 22);
            this.txtNewPartitionSize.TabIndex = 7;
            // 
            // btnDeletePartition
            // 
            this.btnDeletePartition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePartition.Location = new System.Drawing.Point(12, 281);
            this.btnDeletePartition.Name = "btnDeletePartition";
            this.btnDeletePartition.Size = new System.Drawing.Size(158, 45);
            this.btnDeletePartition.TabIndex = 8;
            this.btnDeletePartition.Text = "Delete Partition";
            this.btnDeletePartition.UseVisualStyleBackColor = true;
            this.btnDeletePartition.Click += new System.EventHandler(this.btnDeletePartition_Click);
            // 
            // lblPartitionToDelete
            // 
            this.lblPartitionToDelete.AutoSize = true;
            this.lblPartitionToDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartitionToDelete.Location = new System.Drawing.Point(195, 295);
            this.lblPartitionToDelete.Name = "lblPartitionToDelete";
            this.lblPartitionToDelete.Size = new System.Drawing.Size(119, 16);
            this.lblPartitionToDelete.TabIndex = 9;
            this.lblPartitionToDelete.Text = "Partition to Delete :";
            // 
            // txtPartitionToDelete
            // 
            this.txtPartitionToDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartitionToDelete.Location = new System.Drawing.Point(320, 292);
            this.txtPartitionToDelete.Name = "txtPartitionToDelete";
            this.txtPartitionToDelete.Size = new System.Drawing.Size(71, 22);
            this.txtPartitionToDelete.TabIndex = 10;
            // 
            // lblPartitionName
            // 
            this.lblPartitionName.AutoSize = true;
            this.lblPartitionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartitionName.Location = new System.Drawing.Point(353, 226);
            this.lblPartitionName.Name = "lblPartitionName";
            this.lblPartitionName.Size = new System.Drawing.Size(51, 16);
            this.lblPartitionName.TabIndex = 11;
            this.lblPartitionName.Text = "Name :";
            // 
            // txtPartitionName
            // 
            this.txtPartitionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartitionName.Location = new System.Drawing.Point(410, 223);
            this.txtPartitionName.Name = "txtPartitionName";
            this.txtPartitionName.Size = new System.Drawing.Size(91, 22);
            this.txtPartitionName.TabIndex = 12;
            // 
            // btnExtendPartitionTable
            // 
            this.btnExtendPartitionTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtendPartitionTable.Location = new System.Drawing.Point(12, 343);
            this.btnExtendPartitionTable.Name = "btnExtendPartitionTable";
            this.btnExtendPartitionTable.Size = new System.Drawing.Size(158, 45);
            this.btnExtendPartitionTable.TabIndex = 13;
            this.btnExtendPartitionTable.Text = "Extend Partition Table";
            this.btnExtendPartitionTable.UseVisualStyleBackColor = true;
            this.btnExtendPartitionTable.Click += new System.EventHandler(this.btnExtendPartitionTable_Click);
            // 
            // lblMaxEntries
            // 
            this.lblMaxEntries.AutoSize = true;
            this.lblMaxEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxEntries.Location = new System.Drawing.Point(195, 357);
            this.lblMaxEntries.Name = "lblMaxEntries";
            this.lblMaxEntries.Size = new System.Drawing.Size(83, 16);
            this.lblMaxEntries.TabIndex = 14;
            this.lblMaxEntries.Text = "Max Entries :";
            // 
            // txtMaxEntries
            // 
            this.txtMaxEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxEntries.Location = new System.Drawing.Point(284, 354);
            this.txtMaxEntries.Name = "txtMaxEntries";
            this.txtMaxEntries.Size = new System.Drawing.Size(71, 22);
            this.txtMaxEntries.TabIndex = 15;
            // 
            // lblDeviceIpAddress
            // 
            this.lblDeviceIpAddress.AutoSize = true;
            this.lblDeviceIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviceIpAddress.Location = new System.Drawing.Point(195, 26);
            this.lblDeviceIpAddress.Name = "lblDeviceIpAddress";
            this.lblDeviceIpAddress.Size = new System.Drawing.Size(126, 16);
            this.lblDeviceIpAddress.TabIndex = 16;
            this.lblDeviceIpAddress.Text = "Device IP Address :";
            // 
            // txtDeviceIpAddress
            // 
            this.txtDeviceIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeviceIpAddress.Location = new System.Drawing.Point(327, 23);
            this.txtDeviceIpAddress.Name = "txtDeviceIpAddress";
            this.txtDeviceIpAddress.Size = new System.Drawing.Size(122, 22);
            this.txtDeviceIpAddress.TabIndex = 17;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 400);
            this.Controls.Add(this.txtDeviceIpAddress);
            this.Controls.Add(this.lblDeviceIpAddress);
            this.Controls.Add(this.txtMaxEntries);
            this.Controls.Add(this.lblMaxEntries);
            this.Controls.Add(this.btnExtendPartitionTable);
            this.Controls.Add(this.txtPartitionName);
            this.Controls.Add(this.lblPartitionName);
            this.Controls.Add(this.txtPartitionToDelete);
            this.Controls.Add(this.lblPartitionToDelete);
            this.Controls.Add(this.btnDeletePartition);
            this.Controls.Add(this.txtNewPartitionSize);
            this.Controls.Add(this.lblNewPartitionSize);
            this.Controls.Add(this.btnCreatePartition);
            this.Controls.Add(this.btnPrepareGPT);
            this.Controls.Add(this.txtDataPartitionNewSize);
            this.Controls.Add(this.lblDataPartitionSize);
            this.Controls.Add(this.btnConnectDevice);
            this.Controls.Add(this.btnResizeHFS);
            this.Name = "frmMain";
            this.Text = "iOS Disk Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResizeHFS;
        private System.Windows.Forms.Button btnConnectDevice;
        private System.Windows.Forms.Label lblDataPartitionSize;
        private System.Windows.Forms.TextBox txtDataPartitionNewSize;
        private System.Windows.Forms.Button btnPrepareGPT;
        private System.Windows.Forms.Button btnCreatePartition;
        private System.Windows.Forms.Label lblNewPartitionSize;
        private System.Windows.Forms.TextBox txtNewPartitionSize;
        private System.Windows.Forms.Button btnDeletePartition;
        private System.Windows.Forms.Label lblPartitionToDelete;
        private System.Windows.Forms.TextBox txtPartitionToDelete;
        private System.Windows.Forms.Label lblPartitionName;
        private System.Windows.Forms.TextBox txtPartitionName;
        private System.Windows.Forms.Button btnExtendPartitionTable;
        private System.Windows.Forms.Label lblMaxEntries;
        private System.Windows.Forms.TextBox txtMaxEntries;
        private System.Windows.Forms.Label lblDeviceIpAddress;
        private System.Windows.Forms.TextBox txtDeviceIpAddress;
    }
}

