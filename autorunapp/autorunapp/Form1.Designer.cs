namespace AutoRunApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOK = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.run_app_timer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog_exe = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_check_network = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_network = new System.Windows.Forms.CheckBox();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox_startup = new System.Windows.Forms.CheckBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.textBox_exe_file = new System.Windows.Forms.TextBox();
            this.button_browser = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_check_sql = new System.Windows.Forms.Button();
            this.textBox_udl_file = new System.Windows.Forms.TextBox();
            this.button_open_udl = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radio_check_udl = new System.Windows.Forms.RadioButton();
            this.radio_check_port = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.connect_network_timer = new System.Windows.Forms.Timer(this.components);
            this.connect_sql_timer = new System.Windows.Forms.Timer(this.components);
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(451, 429);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(90, 33);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "&Close";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 10);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 6);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AutoRunApp";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // run_app_timer
            // 
            this.run_app_timer.Tick += new System.EventHandler(this.run_app_timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_check_network);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBox_network);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Check network status ";
            // 
            // button_check_network
            // 
            this.button_check_network.Enabled = false;
            this.button_check_network.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_check_network.Location = new System.Drawing.Point(443, 30);
            this.button_check_network.Name = "button_check_network";
            this.button_check_network.Size = new System.Drawing.Size(90, 33);
            this.button_check_network.TabIndex = 7;
            this.button_check_network.Text = "Check Internet";
            this.button_check_network.UseVisualStyleBackColor = true;
            this.button_check_network.Click += new System.EventHandler(this.button_check_network_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(197, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "...";
            // 
            // checkBox_network
            // 
            this.checkBox_network.AutoSize = true;
            this.checkBox_network.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_network.Location = new System.Drawing.Point(27, 39);
            this.checkBox_network.Name = "checkBox_network";
            this.checkBox_network.Size = new System.Drawing.Size(100, 17);
            this.checkBox_network.TabIndex = 3;
            this.checkBox_network.Text = "Check Network";
            this.checkBox_network.UseVisualStyleBackColor = true;
            this.checkBox_network.CheckedChanged += new System.EventHandler(this.checkBox_network_CheckedChanged);
            // 
            // button_save
            // 
            this.button_save.Enabled = false;
            this.button_save.Location = new System.Drawing.Point(346, 429);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(90, 33);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkBox_startup);
            this.groupBox2.Controls.Add(this.button_clear);
            this.groupBox2.Controls.Add(this.button_run);
            this.groupBox2.Controls.Add(this.textBox_exe_file);
            this.groupBox2.Controls.Add(this.button_browser);
            this.groupBox2.Location = new System.Drawing.Point(9, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 122);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3. Run application";
            // 
            // button2
            // 
            this.button2.Image = global::AutoRunApp.Properties.Resources.icons8_folder_16;
            this.button2.Location = new System.Drawing.Point(200, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 28);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox_startup
            // 
            this.checkBox_startup.AutoSize = true;
            this.checkBox_startup.Enabled = false;
            this.checkBox_startup.Location = new System.Drawing.Point(47, 74);
            this.checkBox_startup.Name = "checkBox_startup";
            this.checkBox_startup.Size = new System.Drawing.Size(147, 17);
            this.checkBox_startup.TabIndex = 13;
            this.checkBox_startup.Text = "Load on Windows startup";
            this.checkBox_startup.UseVisualStyleBackColor = true;
            this.checkBox_startup.Click += new System.EventHandler(this.checkBox_startup_Click);
            // 
            // button_clear
            // 
            this.button_clear.Image = global::AutoRunApp.Properties.Resources.clear_16;
            this.button_clear.Location = new System.Drawing.Point(501, 32);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(28, 28);
            this.button_clear.TabIndex = 7;
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(442, 74);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(90, 33);
            this.button_run.TabIndex = 6;
            this.button_run.Text = "Run App";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.Button_run_Click);
            // 
            // textBox_exe_file
            // 
            this.textBox_exe_file.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_exe_file.Location = new System.Drawing.Point(47, 36);
            this.textBox_exe_file.Name = "textBox_exe_file";
            this.textBox_exe_file.Size = new System.Drawing.Size(448, 20);
            this.textBox_exe_file.TabIndex = 5;
            this.textBox_exe_file.TextChanged += new System.EventHandler(this.textBox_file_TextChanged);
            // 
            // button_browser
            // 
            this.button_browser.Image = global::AutoRunApp.Properties.Resources.opened_16;
            this.button_browser.Location = new System.Drawing.Point(19, 34);
            this.button_browser.Name = "button_browser";
            this.button_browser.Size = new System.Drawing.Size(25, 25);
            this.button_browser.TabIndex = 4;
            this.button_browser.UseVisualStyleBackColor = true;
            this.button_browser.Click += new System.EventHandler(this.button_browser_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_check_sql);
            this.groupBox3.Controls.Add(this.textBox_udl_file);
            this.groupBox3.Controls.Add(this.button_open_udl);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox_port);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.radio_check_udl);
            this.groupBox3.Controls.Add(this.radio_check_port);
            this.groupBox3.Location = new System.Drawing.Point(9, 116);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(552, 150);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "2. Check SQL Server status";
            // 
            // button_check_sql
            // 
            this.button_check_sql.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_check_sql.Location = new System.Drawing.Point(443, 51);
            this.button_check_sql.Name = "button_check_sql";
            this.button_check_sql.Size = new System.Drawing.Size(90, 33);
            this.button_check_sql.TabIndex = 22;
            this.button_check_sql.Text = "Check SQL";
            this.button_check_sql.UseVisualStyleBackColor = true;
            this.button_check_sql.Click += new System.EventHandler(this.button_check_sql_Click);
            // 
            // textBox_udl_file
            // 
            this.textBox_udl_file.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox_udl_file.Location = new System.Drawing.Point(47, 108);
            this.textBox_udl_file.Name = "textBox_udl_file";
            this.textBox_udl_file.Size = new System.Drawing.Size(485, 20);
            this.textBox_udl_file.TabIndex = 21;
            this.textBox_udl_file.TextChanged += new System.EventHandler(this.textBox_udl_file_TextChanged);
            // 
            // button_open_udl
            // 
            this.button_open_udl.Image = global::AutoRunApp.Properties.Resources.opened_16;
            this.button_open_udl.Location = new System.Drawing.Point(19, 105);
            this.button_open_udl.Name = "button_open_udl";
            this.button_open_udl.Size = new System.Drawing.Size(25, 25);
            this.button_open_udl.TabIndex = 20;
            this.button_open_udl.UseVisualStyleBackColor = true;
            this.button_open_udl.Click += new System.EventHandler(this.button_open_udl_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGreen;
            this.label3.Location = new System.Drawing.Point(197, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "...";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(128, 31);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(54, 20);
            this.textBox_port.TabIndex = 18;
            this.textBox_port.Text = "1433";
            this.textBox_port.TextChanged += new System.EventHandler(this.textBox_port_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(197, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "...";
            // 
            // radio_check_udl
            // 
            this.radio_check_udl.AutoSize = true;
            this.radio_check_udl.Location = new System.Drawing.Point(25, 67);
            this.radio_check_udl.Name = "radio_check_udl";
            this.radio_check_udl.Size = new System.Drawing.Size(93, 17);
            this.radio_check_udl.TabIndex = 15;
            this.radio_check_udl.Text = "Using UDL file";
            this.radio_check_udl.UseVisualStyleBackColor = true;
            this.radio_check_udl.CheckedChanged += new System.EventHandler(this.radio_check_port_CheckedChanged);
            // 
            // radio_check_port
            // 
            this.radio_check_port.AutoSize = true;
            this.radio_check_port.Checked = true;
            this.radio_check_port.Location = new System.Drawing.Point(25, 32);
            this.radio_check_port.Name = "radio_check_port";
            this.radio_check_port.Size = new System.Drawing.Size(98, 17);
            this.radio_check_port.TabIndex = 14;
            this.radio_check_port.TabStop = true;
            this.radio_check_port.Text = "Using SQL Port";
            this.radio_check_port.UseVisualStyleBackColor = true;
            this.radio_check_port.CheckedChanged += new System.EventHandler(this.radio_check_port_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 419);
            this.panel1.TabIndex = 12;
            // 
            // connect_network_timer
            // 
            this.connect_network_timer.Tick += new System.EventHandler(this.check_network_timer_Tick);
            // 
            // connect_sql_timer
            // 
            this.connect_sql_timer.Tick += new System.EventHandler(this.check_sql_timer_Tick);
            // 
            // LogBox
            // 
            this.LogBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogBox.BackColor = System.Drawing.Color.Honeydew;
            this.LogBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.LogBox.Location = new System.Drawing.Point(2, 468);
            this.LogBox.MinimumSize = new System.Drawing.Size(580, 152);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(580, 152);
            this.LogBox.TabIndex = 13;
            this.LogBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Logs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(584, 623);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 900);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Delay in running the program V1.0.4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer run_app_timer;
        private System.Windows.Forms.OpenFileDialog openFileDialog_exe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox_network;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_exe_file;
        private System.Windows.Forms.Button button_browser;
        private System.Windows.Forms.Button button_run;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radio_check_udl;
        private System.Windows.Forms.RadioButton radio_check_port;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_open_udl;
        private System.Windows.Forms.TextBox textBox_udl_file;
        private System.Windows.Forms.Button button_check_network;
        private System.Windows.Forms.Button button_check_sql;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox_startup;
        private System.Windows.Forms.Timer connect_network_timer;
        private System.Windows.Forms.Timer connect_sql_timer;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

