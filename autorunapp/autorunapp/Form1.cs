using Squirrel.Shell;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace AutoRunApp
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string name, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public string Setting_ini_file = Directory.GetCurrentDirectory() + "\\" + "Settings.ini";
        public readonly string Setting_Section_Name = "SETTINGS";
        public readonly string Setting_key_delay_check_network_seconds = "Delay Check Network Seconds";
        public readonly string Setting_key_try_check_network_times = "Try Check Network Times";
        public readonly string Setting_key_delay_check_sql_seconds = "Delay Check SQL Seconds";
        public readonly string Setting_key_try_check_sql_times = "Try Check SQL Times";
        public readonly string Setting_key_delay_launch_app_seconds = "Delay launch App Seconds";
        public readonly string Setting_key_try_launch_app_times = "Try launch App Times";

        private string Exe_file_path = "";
        private readonly string Layout_Section_Name = "LAYOUT";
        private readonly string System_Section_Name = "SYSTEM";
        private readonly string Setting_key_exe_path = "EXE Path";
        private readonly string Setting_key_udl_path = "UDL Path";
        private readonly string Setting_key_port = "SQL Port";

        private int DelayCheckNetworkSeconds = 5;   // seconds
        private int TryCheckingNetworkTimes = 3;
        private int DelayCheckSQLSeconds = 5;
        private int TryCheckingSQLTimes = 3;

        private int DelayRunAppSeconds = 5;
        private int TryRunAppTimes = 1;
        private string DefaultSQLPort = "1433";

        private bool ReadyToStart = false;
        private bool Terminating = false;
        private bool IsNetworkConnected = false;
        private bool IsSQLConnected = false;
        private bool IsAppRuning = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            // create pop menu
            this.contextMenuStrip1.Items.Clear();
            this.contextMenuStrip1.Items.Add("Open");
            this.contextMenuStrip1.Items.Add("-");
            this.contextMenuStrip1.Items.Add("Setting");
            this.contextMenuStrip1.Items.Add("-");
            this.contextMenuStrip1.Items.Add("Exit");

            LoadSettingsFromINIFile();

            // check network
            if (checkBox_network.Checked)
                button_check_network_Click(sender, e);

            // check sql server
            button_check_sql_Click(sender, e);

            Application.UseWaitCursor = false;
        }


        private void LoadSettingsFromINIFile()
        {
            bool isSetting = true;
            if (File.Exists(this.Setting_ini_file))
            {
                textBox_exe_file.Text = ReadINI(System_Section_Name, Setting_key_exe_path, this.Setting_ini_file);
                textBox_udl_file.Text = ReadINI(System_Section_Name, Setting_key_udl_path, this.Setting_ini_file);

                checkBox_startup.Checked = bool.Parse(ReadINI(Layout_Section_Name, checkBox_startup.Text, this.Setting_ini_file));
                if (!string.IsNullOrEmpty(textBox_exe_file.Text))
                    this.Exe_file_path = Path.GetDirectoryName(textBox_exe_file.Text);
                else
                    checkBox_startup.Checked = false;

                checkBox_network.Checked = bool.Parse(ReadINI(Layout_Section_Name, checkBox_network.Text, this.Setting_ini_file));
                radio_check_port.Checked = bool.Parse(ReadINI(Layout_Section_Name, radio_check_port.Text, this.Setting_ini_file));

                radio_check_udl.Checked = bool.Parse(ReadINI(System_Section_Name, radio_check_udl.Text, this.Setting_ini_file));

                textBox_port.Text = ReadINI(Layout_Section_Name, Setting_key_port, this.Setting_ini_file);

                ////time in milliseconds   60 seconds = 60 * 1000  
                ///
                string delayCheckNetworkSeconds = ReadINI(Setting_Section_Name, Setting_key_delay_check_network_seconds, this.Setting_ini_file);
                DelayCheckNetworkSeconds = delayCheckNetworkSeconds == "" ? DelayCheckNetworkSeconds : Int32.Parse(delayCheckNetworkSeconds) * 1000;

                string tryCheckingNetworkTimes = ReadINI(Setting_Section_Name, Setting_key_try_check_network_times, this.Setting_ini_file);
                TryCheckingNetworkTimes = tryCheckingNetworkTimes == "" ? TryCheckingNetworkTimes : Int32.Parse(tryCheckingNetworkTimes);

                string delayCheckSQLSeconds = ReadINI(Setting_Section_Name, Setting_key_delay_check_sql_seconds, this.Setting_ini_file);
                DelayCheckSQLSeconds = delayCheckSQLSeconds == "" ? DelayCheckSQLSeconds : Int32.Parse(delayCheckSQLSeconds) * 1000;

                string tryCheckingSQLTimes = ReadINI(Setting_Section_Name, Setting_key_try_check_sql_times, this.Setting_ini_file);
                TryCheckingSQLTimes = tryCheckingSQLTimes == "" ? TryCheckingSQLTimes : Int32.Parse(tryCheckingSQLTimes);

                string delayRunAppSeconds = ReadINI(Setting_Section_Name, Setting_key_delay_launch_app_seconds, this.Setting_ini_file);
                DelayRunAppSeconds = delayRunAppSeconds == "" ? DelayRunAppSeconds : Int32.Parse(delayRunAppSeconds) * 1000;

                string tryRunAppTimes = ReadINI(Setting_Section_Name, Setting_key_try_launch_app_times, this.Setting_ini_file);
                TryRunAppTimes = tryRunAppTimes == "" ? TryRunAppTimes : Int32.Parse(tryRunAppTimes);

                if (string.IsNullOrEmpty(delayCheckNetworkSeconds) || string.IsNullOrEmpty(tryCheckingNetworkTimes) || string.IsNullOrEmpty(delayCheckSQLSeconds) ||
                    string.IsNullOrEmpty(tryCheckingSQLTimes) || string.IsNullOrEmpty(delayRunAppSeconds) || string.IsNullOrEmpty(tryRunAppTimes))
                    isSetting = false;
            }
            else
            {
                checkBox_network.Checked = true;
                button_check_network.Enabled = true;
            }

            if (!isSetting || !File.Exists(this.Setting_ini_file))
            {
                MessageBox.Show("Please set the parameters first.");
                Form2 fSetting = new Form2(this);
                fSetting.Show();
            }


            if (radio_check_port.Checked)
            {
                button_open_udl.Visible = false;
                textBox_udl_file.Visible = false;
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (!IsRunningProcess())
            {
                delayCheckNetwork();
                delayCheckSql();
                checkReadyToStart();
                delayRunAppProcessing();
            }
            else
            {
                this.notifyIcon1.Dispose();
                Terminating = true;
                Application.Exit();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Terminating)
                return;  // the idle state has occurred, and the tray notification should be gone.

            if (e.CloseReason == CloseReason.UserClosing && MessageBox.Show("Are you sure you want to close this form?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
            {
                e.Cancel = true;  // only the user, selecting Cancel in a MessageBox, can do this.
            }

            if (!e.Cancel)
            {
                // The application will shut down.
                e.Cancel = true;
                this.notifyIcon1.Dispose();
                Terminating = true;
                Application.Exit();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Open":
                    Show();
                    WindowState = FormWindowState.Normal;
                    break;
                case "Setting":
                    Form2 fSetting = new Form2(this);   //  open Form2
                    fSetting.Show();
                    break;
                case "Exit":
                    Close();
                    break;
            }
            return;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }


        private void button_browser_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*|Exe files (*.exe)|*.exe";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    textBox_exe_file.Text = openFileDialog.FileName;
                    changePortSaveButton();
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            save_to_setting_ini();
        }

        private void checkBox_network_CheckedChanged(object sender, EventArgs e)
        {
            changePortSaveButton();

            if (checkBox_network.Checked)
                button_check_network.Enabled = true;
            else
                button_check_network.Enabled = false;
            label1.Text = "";
        }

        private void radio_check_port_CheckedChanged(object sender, EventArgs e)
        {

            if (radio_check_port.Checked)
            {
                textBox_port.Visible = true;
                button_check_sql.Enabled = true;

                textBox_udl_file.Visible = false;
                button_open_udl.Visible = false;
            }
            else
            {
                textBox_port.Visible = false;
                textBox_udl_file.Visible = true;
                button_open_udl.Visible = true;

                if (string.IsNullOrEmpty(textBox_udl_file.Text))
                {
                    button_check_sql.Enabled = false;
                }
                else
                {
                    button_check_sql.Enabled = true;
                }
            }

            changePortSaveButton();
            label2.Text = "";
            label3.Text = "";
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_exe_file.Text = null;
        }

        private void textBox_file_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_exe_file.Text))
            {
                button_clear.Enabled = true;
                button_run.Enabled = true;
                checkBox_startup.Enabled = true;
            }
            else
            {
                button_clear.Enabled = false;
                button_run.Enabled = false;
                checkBox_startup.Enabled = false;
            }

            changePortSaveButton();
        }

        private void Button_run_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            string appNamePath = textBox_exe_file.Text;

            if (!string.IsNullOrEmpty(appNamePath))
            {
                if (File.Exists(appNamePath))
                {
                    Exe_file_path = appNamePath;
                    runApplication(Exe_file_path);
                }
            }
            Application.UseWaitCursor = false;
        }

        private void textBox_port_TextChanged(object sender, EventArgs e)
        {
            //   button_save.Enabled = true;
            changePortSaveButton();
            label2.Text = "";
        }

        private void button_check_network_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            label1.Text = "";
            bool network_state = false;
            if (checkBox_network.Checked)
            {
                if (isNetworkConnectionAvailable())
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = "Network connection successful !\n";
                    LogBox.AppendText(label1.Text);
                    network_state = true;
                    button_check_network.Text = "Check Internet";

                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text += "Cannot connect to the internet. \n";
                    LogBox.AppendText(label1.Text);
                    network_state = false;
                }
            }

            IsNetworkConnected = network_state;
            if (IsSQLConnected && !string.IsNullOrEmpty(textBox_exe_file.Text))
                button_run.Enabled = true;
            Application.UseWaitCursor = false;
        }

        private void button_check_sql_Click(object sender, EventArgs e)
        {
            Application.UseWaitCursor = true;
            bool SQLConnection_state = false;

            if (radio_check_port.Checked)
            {
                if (string.IsNullOrEmpty(textBox_port.Text))
                    textBox_port.Text = DefaultSQLPort;

                int port = int.Parse(textBox_port.Text);

                if (isSQLConnectionAvailable("(LOCAL)\\SQLEXPRESS", port))
                {
                    label2.Text = "Found Local SQL Server.\n";
                    button_check_sql.Text = "Check SQL";
                }
                else
                {
                    label2.Text = "Can not found Local SQL Server.\n";
                }
                LogBox.AppendText(label2.Text);

                if (isSqlPortOpen("127.0.0.1", port))
                {
                    label3.ForeColor = Color.Green;
                    label3.Text = "Port " + port + " is opened.\n";
                    SQLConnection_state = true;
                }
                else
                {
                    label3.ForeColor = Color.Red;
                    label3.Text = "Port " + port + " is not open.\n";
                    SQLConnection_state = false;
                }
                LogBox.AppendText(label3.Text);
            }
            else if (radio_check_udl.Checked && (!string.IsNullOrEmpty(textBox_udl_file.Text)))
            {
                string udl_file = textBox_udl_file.Text;
                if (File.Exists(udl_file))
                {
                    string connectionString = getConnectionStringFromUdl(udl_file);
                    if (connectionString != null)
                    {
                        bool Success = checkSQLServerConection(connectionString);
                        if (Success)
                        {
                            SQLConnection_state = true;
                            LogBox.AppendText("SQL Server has connected !\n");
                        }
                        else
                        {
                            label3.ForeColor = Color.Red;
                            label3.Text = "SQL connection is not available.\n";
                            LogBox.AppendText(label3.Text);
                            SQLConnection_state = false;
                        }
                    }
                    else
                    {
                        label3.ForeColor = Color.Red;
                        label3.Text = "SQL connection string error. \n";
                        LogBox.AppendText(label3.Text);
                        SQLConnection_state = false;
                    }
                }
            }
            IsSQLConnected = SQLConnection_state;
            if (IsNetworkConnected && !string.IsNullOrEmpty(textBox_exe_file.Text))
                button_run.Enabled = true;
            Application.UseWaitCursor = false;
        }

        private void button_open_udl_Click(object sender, EventArgs e)
        {
            radio_check_udl.Checked = true;
            textBox_port.Visible = false;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*|Udl files (*.udl)|*.udl";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    textBox_udl_file.Text = openFileDialog.FileName;
                    if (!string.IsNullOrEmpty(textBox_udl_file.Text))
                    {
                        button_check_sql.Enabled = true;
                    }
                }
            }
        }

        private void button_shortcut_Click(object sender, EventArgs e)
        {
            // Application.UseWaitCursor = true;
            Application.UseWaitCursor = true;
            DialogResult dialogResult = MessageBox.Show("Do you want to copy a shortcut to the startup folder? ", "Please confirm",
                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //    string current_Path = Path.GetDirectoryName(Application.ExecutablePath)+"\\";
                string linkFilename = "";
                using (ShellLink shortcut = new ShellLink())
                {
                    shortcut.Target = Application.ExecutablePath;
                    shortcut.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    shortcut.Description = "Shorcut";
                    shortcut.DisplayMode = ShellLink.LinkDisplayMode.edmNormal;

                    linkFilename = Path.Combine(shortcut.WorkingDirectory, string.Format("{0}.lnk", Application.ProductName));

                    shortcut.Save(linkFilename);
                }

                string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                string startupShortcutFilename = Path.Combine(startupFolder, string.Format("{0}.lnk", Application.ProductName));

                File.Copy(linkFilename, startupShortcutFilename, true);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            Application.UseWaitCursor = false;
        }

        private void button_delete_shortcut_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            DialogResult dialogResult = MessageBox.Show("Do you want to remove shorcut from startup folder ? ", "Please confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                string startupShortcutFilename = Path.Combine(startupFolder, string.Format("{0}.lnk", Application.ProductName));

                File.Delete(startupShortcutFilename);
            }
            UseWaitCursor = false;
        }

        private void comboBox_delay_SelectedIndexChanged(object sender, EventArgs e)
        {
            changePortSaveButton();
        }

        private void comboBox_try_times_SelectedIndexChanged(object sender, EventArgs e)
        {
            changePortSaveButton();
        }

        private void textBox_udl_file_TextChanged(object sender, EventArgs e)
        {
            changePortSaveButton();
        }


        /// -----------------------------------------------------------------------------------

        #region functions

        private void changePortSaveButton()
        {
            if (radio_check_port.Checked)
            {
                if (string.IsNullOrEmpty(textBox_port.Text))
                    button_save.Enabled = false;
                else
                    button_save.Enabled = true;
            }
            else
            {
                if (string.IsNullOrEmpty(textBox_udl_file.Text))
                    button_save.Enabled = false;
                else
                    button_save.Enabled = true;
            }
        }

        public string ReadINI(string name, string key, string path)
        {
            StringBuilder sb = new StringBuilder(255);
            int ini = GetPrivateProfileString(name, key, "", sb, 255, path);
            if (ini == 0)
                return "";
            else
                return sb.ToString();
        }
        public void WriteINI(string name, string key, string value, string path)
        {
            WritePrivateProfileString(name, key, value, path);
        }

        private bool isNetworkConnectionAvailable()
        {
            bool _success = false;
            string[] sitesList = { "www.google.com", "www.cloudweigh.nl", "www.nwigroup.com.au" };
            Ping ping = new Ping();
            PingReply reply;
            label1.Text = "";
            int notReturned = 0;
            try
            {
                for (int i = 0; i < sitesList.Length; i++)
                {
                    reply = ping.Send(sitesList[i], 10);
                    if (reply.Status == IPStatus.Success)
                    {
                        _success = true;
                        LogBox.AppendText("Ping " + sitesList[i] + " OK !\n");
                        break;
                    }
                    else
                    {
                        LogBox.AppendText("Failed to ping " + sitesList[i] + " \n");
                        label1.Text += ".";
                        notReturned += 1;
                    }
                }
            }
            catch
            {
                _success = false;
                //throw new Exception(ex.Message);
            }
            return _success;
        }

        private string getConnectionStringFromUdl(string udl_file)
        {
            var udl = File.ReadAllText(udl_file, Encoding.Unicode);
            var rex = new Regex("(Provider[^;]*);(.*)", RegexOptions.Multiline);
            var match = rex.Match(udl);

            if (match.Success)
            {
                string Provider = match.Groups[1].ToString();
                return match.Groups[2].ToString();
            }
            else
            {
                return null;
            }
        }

        private bool checkSQLServerConection(string ConnectionString)
        {
            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var query = "select 1";
                    Console.WriteLine("Executing: {0}", query);

                    var command = new SqlCommand(query, connection);

                    connection.Open();

                    label3.ForeColor = Color.Green;
                    label3.Text = "SQL connection successful !\n";
                    Console.WriteLine(label3.Text);
                    LogBox.AppendText(label3.Text);

                    command.ExecuteScalar();
                    label3.Text += "SQL Query execution successful !\n";
                    Console.WriteLine(label3.Text);
                    LogBox.AppendText(label3.Text);

                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failure: {0}", ex.Message);
                LogBox?.AppendText(ex.StackTrace);
            }
            return false;
        }

        private bool isSQLConnectionAvailable(string address, int port)
        {
            int timeout = 500;
            var result = false;
            try
            {
                using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
                {
                    IAsyncResult asyncResult = socket.BeginConnect(address, port, null, null);
                    result = asyncResult.AsyncWaitHandle.WaitOne(timeout, true);

                    socket.Close();
                }
                return result;
            }
            catch
            {
                return false;
            }
        }

        private bool isSqlPortOpen(string address, int port)
        {
            int timeout = 500;
            var result = false;

            TcpClient client = null;

            try
            {
                client = new TcpClient();
                var task = client.ConnectAsync(address, port);
                if (task.Wait(timeout))
                {
                    //if fails within timeout, task. Wait still returns true.
                    if (client.Connected) // port reachable
                        result = true;
                    else
                        result = false;
                }
            }
            catch
            {
                result = false;
                // connection failed
            }
            finally
            {
                if (client != null)
                    client.Close();
            }
            return result;
        }

        public void save_to_setting_ini()
        {
            Application.UseWaitCursor = true;

            button_save.Enabled = false;
            if (!string.IsNullOrEmpty(textBox_exe_file.Text))
                this.Exe_file_path = Path.GetDirectoryName(textBox_exe_file.Text);
            else
                checkBox_startup.Checked = false;

            //exe file
            WriteINI(System_Section_Name, Setting_key_exe_path, textBox_exe_file.Text, this.Setting_ini_file);

            //network
            string value = checkBox_network.Checked.ToString();
            WriteINI(Layout_Section_Name, checkBox_network.Text, value, this.Setting_ini_file);

            //select sql port
            value = radio_check_port.Checked.ToString();
            WriteINI(Layout_Section_Name, radio_check_port.Text, value, this.Setting_ini_file);

            //sql port
            WriteINI(Layout_Section_Name, Setting_key_port, textBox_port.Text, this.Setting_ini_file);

            //select udl
            value = radio_check_udl.Checked.ToString();
            WriteINI(System_Section_Name, radio_check_udl.Text, value, this.Setting_ini_file);

            //udl path
            WriteINI(System_Section_Name, Setting_key_udl_path, textBox_udl_file.Text, this.Setting_ini_file);

            //load on startup
            value = checkBox_startup.Checked.ToString();
            WriteINI(Layout_Section_Name, checkBox_startup.Text, value, this.Setting_ini_file);
            Application.UseWaitCursor = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (LogBox.Visible)
                LogBox.Visible = false;
            else
                LogBox.Visible = true;
        }

        private void checkBox_startup_Click(object sender, EventArgs e)
        {
            button_save.Enabled = true;
            add_shortcut_to_startup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = folderPath,
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }


        // C:\Users\user_name\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup
        private void add_shortcut_to_startup()
        {
            Application.UseWaitCursor = true;

            if (checkBox_startup.Checked)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to copy a shortcut to the startup folder? ", "Please confirm",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    //    string current_Path = Path.GetDirectoryName(Application.ExecutablePath)+"\\";
                    string linkFilename = "";
                    using (ShellLink shortcut = new ShellLink())
                    {
                        shortcut.Target = Application.ExecutablePath;
                        shortcut.WorkingDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                        shortcut.Description = "Shorcut";
                        shortcut.DisplayMode = ShellLink.LinkDisplayMode.edmNormal;

                        linkFilename = Path.Combine(shortcut.WorkingDirectory, string.Format("{0}.lnk", Application.ProductName));

                        shortcut.Save(linkFilename);
                    }

                    string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                    string startupShortcutFilename = Path.Combine(startupFolder, string.Format("{0}.lnk", Application.ProductName));

                    File.Copy(linkFilename, startupShortcutFilename, true);

                    //startup save to setting.ini
                    var value = checkBox_startup.Checked.ToString();
                    WriteINI(Layout_Section_Name, checkBox_startup.Text, value, this.Setting_ini_file);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to remove shorcut from startup folder ? ", "Please confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    string startupFolder = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                    string startupShortcutFilename = Path.Combine(startupFolder, string.Format("{0}.lnk", Application.ProductName));

                    File.Delete(startupShortcutFilename);
                    //startup save to setting.ini
                    var value = checkBox_startup.Checked.ToString();
                    WriteINI(Layout_Section_Name, checkBox_startup.Text, value, this.Setting_ini_file);
                }
            }
            //  changePortSaveButton();

            Application.UseWaitCursor = false;
        }

        private void checkReadyToStart()
        {
            if (IsNetworkConnected && IsSQLConnected)
            {
                ReadyToStart = true;
                button_check_network.Text = "Check Internet";
                button_check_sql.Text = "Check SQL";
            }
            else
                ReadyToStart = false;
        }

        private void delayRunAppProcessing()
        {
            Application.UseWaitCursor = true;

            string appNamePath = textBox_exe_file.Text;
            if (ReadyToStart && !string.IsNullOrEmpty(appNamePath))
            {
                Console.WriteLine("Info: Ready to run {0}", appNamePath);
                LogBox.AppendText("Try to launch App - " + appNamePath + "\n");

                if (File.Exists(appNamePath))
                {
                    Exe_file_path = appNamePath;

                    if (!checkAppRunning(Path.GetFileName(appNamePath)))
                        runApplication(Exe_file_path);
                    else
                    {
                        if (DelayRunAppSeconds == 0)
                        {
                            UseWaitCursor = true;
                            runApplication(Exe_file_path);
                            UseWaitCursor = false;
                        }
                        else
                        {
                            UseWaitCursor = true;
                            delayRunApplication();
                            UseWaitCursor = false;
                        }
                    }

                    if (IsAppRuning || checkAppRunning(Path.GetFileName(appNamePath)))
                        hiddenForm();
                }
            }
            else
            {
                button_run.Enabled = false;
                Console.WriteLine("Warning: Not ready to run {0}", appNamePath);
                if (string.IsNullOrEmpty(appNamePath))
                    LogBox.AppendText("Waiting to set the App location.  \n");
                else
                    LogBox.AppendText("Warning: Not ready to run - " + appNamePath + "\n");
            }


            Application.UseWaitCursor = false;
        }

        private void runApplication(string appNamePath)
        {
            UseWaitCursor = true;
            string appName = Path.GetFileName(appNamePath);

            Process process = new Process();
            Process[] processName = Process.GetProcessesByName(appName.Substring(0, appName.LastIndexOf('.')));
            if (processName.Length > 0)
            {
                IsAppRuning = true;
                LogBox.AppendText("App already running !\n");
                //  MessageBox.Show("Process already running");

            }
            else
            {
                process.StartInfo.FileName = appNamePath;
                process.Start();
            }

            if (IsAppRuning || checkAppRunning(appName))
                hiddenForm();

            UseWaitCursor = false;
        }


        private bool checkAppRunning(string appFullName)
        {
            string appShortName = appFullName.Substring(0, appFullName.LastIndexOf('.'));
            foreach (var curProcess in Process.GetProcesses())
            {
                if (appShortName == curProcess.ProcessName)
                {
                    Console.WriteLine(curProcess.ProcessName);
                    LogBox.AppendText(curProcess.ProcessName + " is running !\n");
                    IsAppRuning = true;
                    break;
                }
            }
            return IsAppRuning;
        }

        private void hiddenForm()
        {
            if (IsAppRuning)
            {
                this.WindowState = FormWindowState.Minimized;
                this.ShowInTaskbar = false;
                notifyIcon1.Visible = true;
                button_run.Enabled = true;
                UseWaitCursor = false;
            }
        }


        /// ------- delay run app --------------------
        private void delayRunApplication()
        {
            run_app_timer.Interval = DelayRunAppSeconds;
            run_app_timer.Enabled = true;
            run_app_timer.Tick += new EventHandler(run_app_timer_Tick);
        }

        private void run_app_timer_Tick(object sender, EventArgs e)
        {
            button_run.Text = TryRunAppTimes.ToString();
            if (IsAppRuning || TryRunAppTimes < 1)
            {
                run_app_timer.Stop();
                UseWaitCursor = false;
            }
            else
            {
                UseWaitCursor = true;
                LogBox.AppendText("Delay " + (DelayRunAppSeconds / 1000).ToString() + " seconds to launch App.\n");
                LogBox.AppendText("Try to launch App - " + TryRunAppTimes.ToString() + " times left.\n");
                TryRunAppTimes--;
                runApplication(Exe_file_path);
                Thread.Sleep(run_app_timer.Interval);  //time in milliseconds
            }

            string appNamePath = textBox_exe_file.Text;
            string appName = Path.GetFileName(appNamePath);
            if (IsAppRuning || checkAppRunning(appName))
            {
                LogBox.AppendText("App has already been launched !!\n");
                hiddenForm();
            }
        }


        /// ------- delay check network  --------------------
        private void delayCheckNetwork()
        {
            if (!IsNetworkConnected)
            {
                //  button_check_network.Text = TryCheckingNetworkTimes.ToString()+" times";
                LogBox.AppendText("Check network connection. \n");
                connect_network_timer.Interval = DelayCheckNetworkSeconds;  //time in milliseconds
                connect_network_timer.Enabled = true;
                connect_network_timer.Tick += new EventHandler(check_network_timer_Tick);
            }
        }

        private void check_network_timer_Tick(object sender, EventArgs e)
        {
            button_check_network.Text = TryCheckingNetworkTimes.ToString() + " times";
            if (IsNetworkConnected || TryCheckingNetworkTimes < 1)
            {
                connect_network_timer.Stop();
                button_check_network.Text = "Check Internet";
                UseWaitCursor = false;
            }
            else
            {
                UseWaitCursor = true;
                LogBox.AppendText("Delay " + (DelayCheckNetworkSeconds / 1000).ToString() + " seconds to check the network again.\n");
                LogBox.AppendText("Check network connection - " + TryCheckingNetworkTimes.ToString() + " times left.\n");
                button_check_network_Click(sender, e);
                TryCheckingNetworkTimes--;

                Thread.Sleep(DelayCheckNetworkSeconds);  //time in milliseconds
            }

            checkReadyToStart();
            delayCheckSql();
            delayRunAppProcessing();
        }

        /// ------- delay check sql --------------------
        private void delayCheckSql()
        {
            if (!IsSQLConnected)
            {
                //  button_check_sql.Text = TryCheckingSQLTimes.ToString() + " times";
                LogBox.AppendText("Check SQL Server connection .\n");
                connect_sql_timer.Interval = DelayCheckSQLSeconds;  //time in milliseconds
                connect_sql_timer.Enabled = true;
                connect_sql_timer.Tick += new EventHandler(check_sql_timer_Tick);
            }
        }

        private void check_sql_timer_Tick(object sender, EventArgs e)
        {
            button_check_sql.Text = TryCheckingSQLTimes.ToString() + " times";
            if (IsSQLConnected || TryCheckingSQLTimes < 1)
            {
                connect_sql_timer.Stop();
                button_check_sql.Text = "Check SQL";
                UseWaitCursor = false;
            }
            else
            {
                UseWaitCursor = true;
                LogBox.AppendText("Delay " + (DelayCheckSQLSeconds / 1000).ToString() + " seconds to check the SQL Server again.\n");
                LogBox.AppendText("Check SQL Server connection - " + TryCheckingSQLTimes.ToString() + " times left. \n");
                button_check_sql_Click(sender, e);
                TryCheckingSQLTimes--;
                Thread.Sleep(DelayCheckSQLSeconds);  //time in milliseconds
            }

            checkReadyToStart();
            delayCheckNetwork();
            delayRunAppProcessing();
        }


        // check app self running
        private bool IsRunningProcess()
        {
            bool returnValue = false;
            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    if (process.ProcessName == current.ProcessName)
                    {
                        var runningProcess = process;
                        returnValue = true;
                        break;
                    }
                }
            }
            return returnValue;
        }


        #endregion



    }
}
