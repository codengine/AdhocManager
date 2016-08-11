namespace AdhocManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.grpSettings = new System.Windows.Forms.GroupBox();
            this.btnConnections = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.lblSSID = new System.Windows.Forms.Label();
            this.txtSSID = new System.Windows.Forms.TextBox();
            this.grpCmdOutput = new System.Windows.Forms.GroupBox();
            this.cmdOutput = new System.Windows.Forms.RichTextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.grpNetworkDevices = new System.Windows.Forms.GroupBox();
            this.networkDevices = new System.Windows.Forms.TreeView();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStartNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStopNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRefreshAdapters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageConnections = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCmdsListAdhocNetworks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCmdsListWirelessDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.showWLANInterfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGithub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGithubIssues = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGithubProjectPage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGithubWiki = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSettings.SuspendLayout();
            this.grpCmdOutput.SuspendLayout();
            this.grpNetworkDevices.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSettings
            // 
            this.grpSettings.Controls.Add(this.btnConnections);
            this.grpSettings.Controls.Add(this.btnStop);
            this.grpSettings.Controls.Add(this.btnStart);
            this.grpSettings.Controls.Add(this.lblPasswd);
            this.grpSettings.Controls.Add(this.txtPasswd);
            this.grpSettings.Controls.Add(this.lblSSID);
            this.grpSettings.Controls.Add(this.txtSSID);
            this.grpSettings.Location = new System.Drawing.Point(12, 27);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.Size = new System.Drawing.Size(321, 101);
            this.grpSettings.TabIndex = 0;
            this.grpSettings.TabStop = false;
            this.grpSettings.Text = "Settings";
            // 
            // btnConnections
            // 
            this.btnConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConnections.Location = new System.Drawing.Point(80, 72);
            this.btnConnections.Name = "btnConnections";
            this.btnConnections.Size = new System.Drawing.Size(156, 23);
            this.btnConnections.TabIndex = 8;
            this.btnConnections.Text = "Manage Connections...";
            this.btnConnections.UseVisualStyleBackColor = true;
            this.btnConnections.Click += new System.EventHandler(this.btnConnections_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Location = new System.Drawing.Point(242, 44);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(73, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(242, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(73, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Location = new System.Drawing.Point(6, 48);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(53, 13);
            this.lblPasswd.TabIndex = 5;
            this.lblPasswd.Text = "Password";
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(65, 45);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(171, 20);
            this.txtPasswd.TabIndex = 4;
            this.txtPasswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxes_KeyDown);
            // 
            // lblSSID
            // 
            this.lblSSID.AutoSize = true;
            this.lblSSID.Location = new System.Drawing.Point(6, 22);
            this.lblSSID.Name = "lblSSID";
            this.lblSSID.Size = new System.Drawing.Size(32, 13);
            this.lblSSID.TabIndex = 3;
            this.lblSSID.Text = "SSID";
            // 
            // txtSSID
            // 
            this.txtSSID.Location = new System.Drawing.Point(65, 19);
            this.txtSSID.MaxLength = 32;
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.Size = new System.Drawing.Size(171, 20);
            this.txtSSID.TabIndex = 2;
            this.txtSSID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxes_KeyDown);
            // 
            // grpCmdOutput
            // 
            this.grpCmdOutput.Controls.Add(this.cmdOutput);
            this.grpCmdOutput.Location = new System.Drawing.Point(339, 27);
            this.grpCmdOutput.Name = "grpCmdOutput";
            this.grpCmdOutput.Size = new System.Drawing.Size(579, 321);
            this.grpCmdOutput.TabIndex = 3;
            this.grpCmdOutput.TabStop = false;
            this.grpCmdOutput.Text = "Output";
            // 
            // cmdOutput
            // 
            this.cmdOutput.BackColor = System.Drawing.Color.Black;
            this.cmdOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOutput.ForeColor = System.Drawing.Color.Lime;
            this.cmdOutput.Location = new System.Drawing.Point(6, 19);
            this.cmdOutput.Name = "cmdOutput";
            this.cmdOutput.ReadOnly = true;
            this.cmdOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.cmdOutput.Size = new System.Drawing.Size(567, 295);
            this.cmdOutput.TabIndex = 3;
            this.cmdOutput.Text = "";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "empty.png");
            this.imageList.Images.SetKeyName(1, "1470879932_pci.png");
            this.imageList.Images.SetKeyName(2, "network_ethernet.png");
            this.imageList.Images.SetKeyName(3, "1470879750_wifi.png");
            this.imageList.Images.SetKeyName(4, "telephone.png");
            this.imageList.Images.SetKeyName(5, "arrow_down.png");
            this.imageList.Images.SetKeyName(6, "arrow_up.png");
            this.imageList.Images.SetKeyName(7, "information.png");
            this.imageList.Images.SetKeyName(8, "1470889266_Dashboard.png");
            // 
            // grpNetworkDevices
            // 
            this.grpNetworkDevices.Controls.Add(this.networkDevices);
            this.grpNetworkDevices.Location = new System.Drawing.Point(12, 134);
            this.grpNetworkDevices.Name = "grpNetworkDevices";
            this.grpNetworkDevices.Size = new System.Drawing.Size(321, 214);
            this.grpNetworkDevices.TabIndex = 4;
            this.grpNetworkDevices.TabStop = false;
            this.grpNetworkDevices.Text = "Network Connections (F5 to refresh)";
            // 
            // networkDevices
            // 
            this.networkDevices.ImageIndex = 0;
            this.networkDevices.ImageList = this.imageList;
            this.networkDevices.Location = new System.Drawing.Point(9, 19);
            this.networkDevices.Name = "networkDevices";
            this.networkDevices.SelectedImageIndex = 0;
            this.networkDevices.Size = new System.Drawing.Size(306, 188);
            this.networkDevices.TabIndex = 5;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.toolStripMenuItem3});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(924, 24);
            this.mainMenu.TabIndex = 5;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStartNetwork,
            this.mnuStopNetwork,
            this.toolStripMenuItem2,
            this.mnuRefreshAdapters,
            this.mnuManageConnections,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuStartNetwork
            // 
            this.mnuStartNetwork.Name = "mnuStartNetwork";
            this.mnuStartNetwork.Size = new System.Drawing.Size(250, 22);
            this.mnuStartNetwork.Text = "Start Network";
            this.mnuStartNetwork.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mnuStopNetwork
            // 
            this.mnuStopNetwork.Name = "mnuStopNetwork";
            this.mnuStopNetwork.Size = new System.Drawing.Size(250, 22);
            this.mnuStopNetwork.Text = "Stop Network";
            this.mnuStopNetwork.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(247, 6);
            // 
            // mnuRefreshAdapters
            // 
            this.mnuRefreshAdapters.Name = "mnuRefreshAdapters";
            this.mnuRefreshAdapters.ShortcutKeyDisplayString = "F5";
            this.mnuRefreshAdapters.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mnuRefreshAdapters.Size = new System.Drawing.Size(250, 22);
            this.mnuRefreshAdapters.Text = "Refresh Network Connections";
            this.mnuRefreshAdapters.Click += new System.EventHandler(this.mnuRefreshAdapters_Click);
            // 
            // mnuManageConnections
            // 
            this.mnuManageConnections.Name = "mnuManageConnections";
            this.mnuManageConnections.Size = new System.Drawing.Size(250, 22);
            this.mnuManageConnections.Text = "Manage Connections...";
            this.mnuManageConnections.Click += new System.EventHandler(this.btnConnections_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(247, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(250, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCmdsListAdhocNetworks,
            this.mnuCmdsListWirelessDevices,
            this.showWLANInterfacesToolStripMenuItem});
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "Commands";
            // 
            // mnuCmdsListAdhocNetworks
            // 
            this.mnuCmdsListAdhocNetworks.Name = "mnuCmdsListAdhocNetworks";
            this.mnuCmdsListAdhocNetworks.Size = new System.Drawing.Size(196, 22);
            this.mnuCmdsListAdhocNetworks.Tag = "ListHostedNetworks";
            this.mnuCmdsListAdhocNetworks.Text = "Show AdHoc Networks";
            this.mnuCmdsListAdhocNetworks.Click += new System.EventHandler(this.RunCommand);
            // 
            // mnuCmdsListWirelessDevices
            // 
            this.mnuCmdsListWirelessDevices.Name = "mnuCmdsListWirelessDevices";
            this.mnuCmdsListWirelessDevices.Size = new System.Drawing.Size(196, 22);
            this.mnuCmdsListWirelessDevices.Tag = "ListWirelessDrivers";
            this.mnuCmdsListWirelessDevices.Text = "Show WLAN Drivers";
            this.mnuCmdsListWirelessDevices.Click += new System.EventHandler(this.RunCommand);
            // 
            // showWLANInterfacesToolStripMenuItem
            // 
            this.showWLANInterfacesToolStripMenuItem.Name = "showWLANInterfacesToolStripMenuItem";
            this.showWLANInterfacesToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.showWLANInterfacesToolStripMenuItem.Tag = "ListWirelessInterfaces";
            this.showWLANInterfacesToolStripMenuItem.Text = "Show WLAN Interfaces";
            this.showWLANInterfacesToolStripMenuItem.Click += new System.EventHandler(this.RunCommand);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGithub,
            this.toolStripMenuItem5,
            this.mnuWebsite});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem3.Text = "?";
            // 
            // mnuGithub
            // 
            this.mnuGithub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGithubIssues,
            this.mnuGithubProjectPage,
            this.mnuGithubWiki});
            this.mnuGithub.Name = "mnuGithub";
            this.mnuGithub.Size = new System.Drawing.Size(152, 22);
            this.mnuGithub.Text = "Github";
            // 
            // mnuGithubIssues
            // 
            this.mnuGithubIssues.Name = "mnuGithubIssues";
            this.mnuGithubIssues.Size = new System.Drawing.Size(152, 22);
            this.mnuGithubIssues.Text = "Report a Bug";
            this.mnuGithubIssues.Click += new System.EventHandler(this.mnuGithubIssues_Click);
            // 
            // mnuGithubProjectPage
            // 
            this.mnuGithubProjectPage.Name = "mnuGithubProjectPage";
            this.mnuGithubProjectPage.Size = new System.Drawing.Size(152, 22);
            this.mnuGithubProjectPage.Text = "Project Page";
            this.mnuGithubProjectPage.Click += new System.EventHandler(this.mnuGithubProjectPage_Click);
            // 
            // mnuGithubWiki
            // 
            this.mnuGithubWiki.Name = "mnuGithubWiki";
            this.mnuGithubWiki.Size = new System.Drawing.Size(152, 22);
            this.mnuGithubWiki.Text = "Wiki";
            this.mnuGithubWiki.Click += new System.EventHandler(this.mnuGithubWiki_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 6);
            // 
            // mnuWebsite
            // 
            this.mnuWebsite.Name = "mnuWebsite";
            this.mnuWebsite.Size = new System.Drawing.Size(152, 22);
            this.mnuWebsite.Text = "Website";
            this.mnuWebsite.Click += new System.EventHandler(this.mnuWebsite_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 353);
            this.Controls.Add(this.grpNetworkDevices);
            this.Controls.Add(this.grpCmdOutput);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "AdhocManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.grpSettings.ResumeLayout(false);
            this.grpSettings.PerformLayout();
            this.grpCmdOutput.ResumeLayout(false);
            this.grpNetworkDevices.ResumeLayout(false);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSettings;
        private System.Windows.Forms.TextBox txtSSID;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.Label lblSSID;
        private System.Windows.Forms.GroupBox grpCmdOutput;
        private System.Windows.Forms.RichTextBox cmdOutput;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.GroupBox grpNetworkDevices;
        private System.Windows.Forms.TreeView networkDevices;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStartNetwork;
        private System.Windows.Forms.ToolStripMenuItem mnuStopNetwork;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshAdapters;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCmdsListAdhocNetworks;
        private System.Windows.Forms.ToolStripMenuItem mnuCmdsListWirelessDevices;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuGithub;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Button btnConnections;
        private System.Windows.Forms.ToolStripMenuItem mnuManageConnections;
        private System.Windows.Forms.ToolStripMenuItem showWLANInterfacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGithubProjectPage;
        private System.Windows.Forms.ToolStripMenuItem mnuGithubWiki;
        private System.Windows.Forms.ToolStripMenuItem mnuGithubIssues;
        private System.Windows.Forms.ToolStripMenuItem mnuWebsite;
    }
}

