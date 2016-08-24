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
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStartNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStopNetwork = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuRefreshAdapters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManageConnections = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCommands = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCmdsListAdhocNetworks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCmdsListWirelessDevices = new System.Windows.Forms.ToolStripMenuItem();
            this.showWLANInterfacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLangDE = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLangEN = new System.Windows.Forms.ToolStripMenuItem();
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
            resources.ApplyResources(this.grpSettings, "grpSettings");
            this.grpSettings.Controls.Add(this.btnConnections);
            this.grpSettings.Controls.Add(this.btnStop);
            this.grpSettings.Controls.Add(this.btnStart);
            this.grpSettings.Controls.Add(this.lblPasswd);
            this.grpSettings.Controls.Add(this.txtPasswd);
            this.grpSettings.Controls.Add(this.lblSSID);
            this.grpSettings.Controls.Add(this.txtSSID);
            this.grpSettings.Name = "grpSettings";
            this.grpSettings.TabStop = false;
            // 
            // btnConnections
            // 
            resources.ApplyResources(this.btnConnections, "btnConnections");
            this.btnConnections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnConnections.Name = "btnConnections";
            this.btnConnections.UseVisualStyleBackColor = true;
            this.btnConnections.Click += new System.EventHandler(this.btnConnections_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPasswd
            // 
            resources.ApplyResources(this.lblPasswd, "lblPasswd");
            this.lblPasswd.Name = "lblPasswd";
            // 
            // txtPasswd
            // 
            resources.ApplyResources(this.txtPasswd, "txtPasswd");
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxes_KeyDown);
            // 
            // lblSSID
            // 
            resources.ApplyResources(this.lblSSID, "lblSSID");
            this.lblSSID.Name = "lblSSID";
            // 
            // txtSSID
            // 
            resources.ApplyResources(this.txtSSID, "txtSSID");
            this.txtSSID.Name = "txtSSID";
            this.txtSSID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxes_KeyDown);
            // 
            // grpCmdOutput
            // 
            resources.ApplyResources(this.grpCmdOutput, "grpCmdOutput");
            this.grpCmdOutput.Controls.Add(this.cmdOutput);
            this.grpCmdOutput.Name = "grpCmdOutput";
            this.grpCmdOutput.TabStop = false;
            // 
            // cmdOutput
            // 
            resources.ApplyResources(this.cmdOutput, "cmdOutput");
            this.cmdOutput.BackColor = System.Drawing.Color.Black;
            this.cmdOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cmdOutput.ForeColor = System.Drawing.Color.Lime;
            this.cmdOutput.Name = "cmdOutput";
            this.cmdOutput.ReadOnly = true;
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
            resources.ApplyResources(this.grpNetworkDevices, "grpNetworkDevices");
            this.grpNetworkDevices.Controls.Add(this.networkDevices);
            this.grpNetworkDevices.Name = "grpNetworkDevices";
            this.grpNetworkDevices.TabStop = false;
            // 
            // networkDevices
            // 
            resources.ApplyResources(this.networkDevices, "networkDevices");
            this.networkDevices.ImageList = this.imageList;
            this.networkDevices.Name = "networkDevices";
            // 
            // mainMenu
            // 
            resources.ApplyResources(this.mainMenu, "mainMenu");
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuCommands,
            this.mnuOptions,
            this.toolStripMenuItem3});
            this.mainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mainMenu.Name = "mainMenu";
            // 
            // mnuFile
            // 
            resources.ApplyResources(this.mnuFile, "mnuFile");
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStartNetwork,
            this.mnuStopNetwork,
            this.toolStripMenuItem2,
            this.mnuRefreshAdapters,
            this.mnuManageConnections,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            // 
            // mnuStartNetwork
            // 
            resources.ApplyResources(this.mnuStartNetwork, "mnuStartNetwork");
            this.mnuStartNetwork.Name = "mnuStartNetwork";
            this.mnuStartNetwork.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mnuStopNetwork
            // 
            resources.ApplyResources(this.mnuStopNetwork, "mnuStopNetwork");
            this.mnuStopNetwork.Name = "mnuStopNetwork";
            this.mnuStopNetwork.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // mnuRefreshAdapters
            // 
            resources.ApplyResources(this.mnuRefreshAdapters, "mnuRefreshAdapters");
            this.mnuRefreshAdapters.Name = "mnuRefreshAdapters";
            this.mnuRefreshAdapters.Click += new System.EventHandler(this.mnuRefreshAdapters_Click);
            // 
            // mnuManageConnections
            // 
            resources.ApplyResources(this.mnuManageConnections, "mnuManageConnections");
            this.mnuManageConnections.Name = "mnuManageConnections";
            this.mnuManageConnections.Click += new System.EventHandler(this.btnConnections_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // mnuExit
            // 
            resources.ApplyResources(this.mnuExit, "mnuExit");
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuCommands
            // 
            resources.ApplyResources(this.mnuCommands, "mnuCommands");
            this.mnuCommands.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCmdsListAdhocNetworks,
            this.mnuCmdsListWirelessDevices,
            this.showWLANInterfacesToolStripMenuItem});
            this.mnuCommands.Name = "mnuCommands";
            // 
            // mnuCmdsListAdhocNetworks
            // 
            resources.ApplyResources(this.mnuCmdsListAdhocNetworks, "mnuCmdsListAdhocNetworks");
            this.mnuCmdsListAdhocNetworks.Name = "mnuCmdsListAdhocNetworks";
            this.mnuCmdsListAdhocNetworks.Tag = "ListHostedNetworks";
            this.mnuCmdsListAdhocNetworks.Click += new System.EventHandler(this.RunCommand);
            // 
            // mnuCmdsListWirelessDevices
            // 
            resources.ApplyResources(this.mnuCmdsListWirelessDevices, "mnuCmdsListWirelessDevices");
            this.mnuCmdsListWirelessDevices.Name = "mnuCmdsListWirelessDevices";
            this.mnuCmdsListWirelessDevices.Tag = "ListWirelessDrivers";
            this.mnuCmdsListWirelessDevices.Click += new System.EventHandler(this.RunCommand);
            // 
            // showWLANInterfacesToolStripMenuItem
            // 
            resources.ApplyResources(this.showWLANInterfacesToolStripMenuItem, "showWLANInterfacesToolStripMenuItem");
            this.showWLANInterfacesToolStripMenuItem.Name = "showWLANInterfacesToolStripMenuItem";
            this.showWLANInterfacesToolStripMenuItem.Tag = "ListWirelessInterfaces";
            this.showWLANInterfacesToolStripMenuItem.Click += new System.EventHandler(this.RunCommand);
            // 
            // mnuOptions
            // 
            resources.ApplyResources(this.mnuOptions, "mnuOptions");
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLang});
            this.mnuOptions.Name = "mnuOptions";
            // 
            // mnuLang
            // 
            resources.ApplyResources(this.mnuLang, "mnuLang");
            this.mnuLang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLangDE,
            this.mnuLangEN});
            this.mnuLang.Name = "mnuLang";
            // 
            // mnuLangDE
            // 
            resources.ApplyResources(this.mnuLangDE, "mnuLangDE");
            this.mnuLangDE.Name = "mnuLangDE";
            this.mnuLangDE.Click += new System.EventHandler(this.mnuLangDE_Click);
            // 
            // mnuLangEN
            // 
            resources.ApplyResources(this.mnuLangEN, "mnuLangEN");
            this.mnuLangEN.Name = "mnuLangEN";
            this.mnuLangEN.Click += new System.EventHandler(this.mnuLangEN_Click);
            // 
            // toolStripMenuItem3
            // 
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGithub,
            this.toolStripMenuItem5,
            this.mnuWebsite});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // mnuGithub
            // 
            resources.ApplyResources(this.mnuGithub, "mnuGithub");
            this.mnuGithub.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGithubIssues,
            this.mnuGithubProjectPage,
            this.mnuGithubWiki});
            this.mnuGithub.Name = "mnuGithub";
            // 
            // mnuGithubIssues
            // 
            resources.ApplyResources(this.mnuGithubIssues, "mnuGithubIssues");
            this.mnuGithubIssues.Name = "mnuGithubIssues";
            this.mnuGithubIssues.Click += new System.EventHandler(this.mnuGithubIssues_Click);
            // 
            // mnuGithubProjectPage
            // 
            resources.ApplyResources(this.mnuGithubProjectPage, "mnuGithubProjectPage");
            this.mnuGithubProjectPage.Name = "mnuGithubProjectPage";
            this.mnuGithubProjectPage.Click += new System.EventHandler(this.mnuGithubProjectPage_Click);
            // 
            // mnuGithubWiki
            // 
            resources.ApplyResources(this.mnuGithubWiki, "mnuGithubWiki");
            this.mnuGithubWiki.Name = "mnuGithubWiki";
            this.mnuGithubWiki.Click += new System.EventHandler(this.mnuGithubWiki_Click);
            // 
            // toolStripMenuItem5
            // 
            resources.ApplyResources(this.toolStripMenuItem5, "toolStripMenuItem5");
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            // 
            // mnuWebsite
            // 
            resources.ApplyResources(this.mnuWebsite, "mnuWebsite");
            this.mnuWebsite.Name = "mnuWebsite";
            this.mnuWebsite.Click += new System.EventHandler(this.mnuWebsite_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpNetworkDevices);
            this.Controls.Add(this.grpCmdOutput);
            this.Controls.Add(this.grpSettings);
            this.Controls.Add(this.mainMenu);
            this.KeyPreview = true;
            this.Name = "MainForm";
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
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuStartNetwork;
        private System.Windows.Forms.ToolStripMenuItem mnuStopNetwork;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshAdapters;
        private System.Windows.Forms.ToolStripMenuItem mnuCommands;
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
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuLang;
        private System.Windows.Forms.ToolStripMenuItem mnuLangDE;
        private System.Windows.Forms.ToolStripMenuItem mnuLangEN;
    }
}

