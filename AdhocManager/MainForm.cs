using System;
using System.Diagnostics;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AdhocManager.Networking;
using AdhocManager.Properties;
using log4net;

namespace AdhocManager
{
    public partial class MainForm : Form
    {
        private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static readonly SettingsManager Settings = new SettingsManager();
        private readonly NetshManager _netshManager;

        public MainForm()
        {
            var currentLanguage = InitializeLanguage();           
            InitializeComponent();
            SetCheckboxesForLanguage(currentLanguage);
            Text = Text + " v" + AssemblyUtils.GetMajorMinorRevisionVersion(Assembly.GetExecutingAssembly());
            InitializeTooltips();
            LoadSettings();
            _netshManager = new NetshManager();
            UpdateAdapters();
        }

        private void SetCheckboxesForLanguage(string language)
        {
            switch (language)
            {
                case "en":
                    mnuLangDE.Checked = false;
                    mnuLangEN.Checked = true;
                    break;
                case "de":
                    mnuLangDE.Checked = true;
                    mnuLangEN.Checked = false;
                    break;
            }
        }

        private static string InitializeLanguage()
        {
            string currentLanguage;

            if (!string.IsNullOrEmpty(Settings.Language))
            {
                currentLanguage = Settings.Language;
                var culture = new CultureInfo(Settings.Language);
                Resources.Culture = culture;
                Thread.CurrentThread.CurrentUICulture = culture;
            }
            else
            {
                currentLanguage = "en";
            }

            return currentLanguage;
        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        private void InitializeTooltips()
        {
            var toolTip = new ToolTip();
            toolTip.SetToolTip(btnStart, Resources.MainForm_Start_Tooltip);
            mnuStartNetwork.ToolTipText = Resources.MainForm_Start_Tooltip;
            toolTip.SetToolTip(btnStop, Resources.MainForm_Stop_Tooltip);
            mnuStopNetwork.ToolTipText = Resources.MainForm_Stop_Tooltip;
            toolTip.SetToolTip(btnConnections, Resources.MainForm_Connections_Tooltip);
            toolTip.SetToolTip(txtSSID, Resources.MainForm_SSID_Tooltip);
            toolTip.SetToolTip(txtPasswd, Resources.MainForm_Password_Tooltip);
        }

        private void LoadSettings()
        {
            Logger.Debug("Loading settings...");
            txtPasswd.Text = Settings.Password;
            txtSSID.Text = Settings.Ssid;
            Logger.Debug("Settings loaded...");
        }

        private void SaveSettings()
        {
            Logger.Debug("Saving settings...");
            Settings.Ssid = txtSSID.Text;
            Settings.Password = txtPasswd.Text;
            Settings.Save();
            Logger.Debug("Settings saved");
        }

        private void LockControls()
        {
            SetControlEnabled(false);
        }

        private void UnlockControls()
        {
            SetControlEnabled(true);
        }

        private void SetControlEnabled(bool status)
        {
            grpSettings.Enabled = status;
            mainMenu.Enabled = status;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartHostedNetwork();
        }

        private void AppendProcessOutput(ProcessResult result)
        {
            cmdOutput.Text += result.Output + Environment.NewLine;
        }

        private void StartHostedNetwork()
        {
            SaveSettings();
            Cursor = Cursors.WaitCursor;
            cmdOutput.Text = "";
            LockControls();

            try
            {
                var setupResult = _netshManager.ConfigureHostedNetwork(txtSSID.Text, txtPasswd.Text);
                AppendProcessOutput(setupResult);

                if (!setupResult.IsSuccessful())
                {
                    MessageBox.Show(Resources.MainForm_Start_SettingsError, Resources.MainForm_Error);
                    return;
                }

                var startResult = _netshManager.StartHostedNetwork();
                AppendProcessOutput(startResult);

                if (!startResult.IsSuccessful())
                {
                    MessageBox.Show(Resources.MainForm_Start_StartHostednetworkError, Resources.MainForm_Error);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(Resources.MainForm_UnhandledException, ex);
                MessageBox.Show(Resources.MainForm_UnhandledException + ": " + ex.Message, Resources.MainForm_Error);
            }
            finally
            {
                Cursor = DefaultCursor;
                UpdateAdapters();
                UnlockControls();
            }
        }

        private void UpdateAdapters()
        {
            Logger.Debug("Updating adapters...");
            Cursor = Cursors.WaitCursor;

            try
            {
                networkDevices.Nodes.Clear();
                Logger.Debug("Retrieving network interfaces...");
                var adapters = NetworkInterface.GetAllNetworkInterfaces();
                foreach (var adapter in adapters)
                {
                    Logger.Debug(string.Format("Adding network adapter node for {0}...", adapter.Name));
                    var node = new NetworkAdapterNode(adapter);
                    networkDevices.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                Logger.Warn("Unhandled Exception while obtaining the adapter list", ex);
                MessageBox.Show(Resources.MainForm_UpdateAdapters_Exception, Resources.MainForm_UnhandledException);
            }
            finally
            {
                Cursor = DefaultCursor;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopHostedNetwork();
        }

        private ProcessResult _runSingleCommand(SimpleCommand command)
        {
            Cursor = Cursors.WaitCursor;
            cmdOutput.Text = "";
            LockControls();

            try
            {
                var result = command.Invoke();
                cmdOutput.Text += result.Output;
                return result;
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Exception while executing the command {0}", command.Method.Name), ex);
                MessageBox.Show(Resources.MainForm_UnhandledException + ": " + ex.Message, Resources.MainForm_Error);
                return ProcessResult.Of(ex);
            }
            finally
            {
                Cursor = DefaultCursor;
                UnlockControls();
            }
        }

        private void StopHostedNetwork()
        {
            if (!_runSingleCommand(_netshManager.StopHostedNetwork).IsSuccessful())
            {
                MessageBox.Show(Resources.MainForm_Stop_StopHostednetworkError, Resources.MainForm_Error);
            }
            UpdateAdapters();
        }

        private void mnuRefreshAdapters_Click(object sender, EventArgs e)
        {
            UpdateAdapters();
        }

        private void txtBoxes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                StartHostedNetwork();
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show(Resources.MainForm_Exit_Dialog, Resources.MainForm_Question,
                MessageBoxButtons.YesNoCancel);
            switch (result)
            {
                case DialogResult.Cancel:
                case DialogResult.None:
                    e.Cancel = true;
                    return;
                case DialogResult.Yes:
                    StopHostedNetwork();
                    break;
                default:
                    e.Cancel = false;
                    break;
            }
        }



        private void btnConnections_Click(object sender, EventArgs e)
        {
            var startInfo = new ProcessStartInfo("NCPA.cpl") {UseShellExecute = true};
            Process.Start(startInfo);
        }

        private void RunCommand(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            if (menuItem == null) return;

            if (!string.IsNullOrEmpty(menuItem.Tag as string))
            {
                CommandAlias commandAlias;
                if (Enum.TryParse((string) menuItem.Tag, false, out commandAlias))
                {
                    _runSingleCommand(() => _netshManager.RunCommand(commandAlias));
                }
            }
        }

        private delegate ProcessResult SimpleCommand();

        #region GithubLinks
        private void mnuGithubWiki_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/codengine/AdhocManager/wiki");
        }

        private void mnuGithubProjectPage_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/codengine/AdhocManager");
        }

        private void mnuGithubIssues_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/codengine/AdhocManager/issues");
        }

        private void mnuWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("https://codengine.github.io/AdhocManager/");
        }
        #endregion

        private static void SetLang(string lang)
        {
            Settings.Language = lang;
            Settings.Save();

            if (MessageBox.Show(Resources.MainForm_Restart_Required, Resources.MainForm_Question, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void mnuLangEN_Click(object sender, EventArgs e)
        {
            SetCheckboxesForLanguage("en");
            SetLang("en");
        }

        private void mnuLangDE_Click(object sender, EventArgs e)
        {
            SetCheckboxesForLanguage("de");
            SetLang("de");
        }
    }
}